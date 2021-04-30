using System;
using YesSIMobileAPI.API;
using System.Collections.Generic;
using System.Linq;
using YesSIMobileAPI.Data;
using System.Threading.Tasks;
using YesSIMobileAPI.Models;
using YesSIMobileModels.Models2;
using System.Net.Mail;
using System.Net;

namespace YesSIMobileAPI.Data
{
    public class MockWebApi : IAdmWebData
    {
            private readonly DBContextClass _Context1;
            private readonly ApiCall Api;

            public MockWebApi(DBContextClass db4)
            {
                _Context1 = db4;
            }

            public void Delete(Guid id)
            {
                AdmLicense License = (AdmLicense)_Context1.AdmLicenses.Where(x => x.Pkey.Equals(id));
                _Context1.AdmLicenses.Remove(License);
                _Context1.SaveChanges();
            }


            public List<AdmLicense> GetLicensees()
            {
                return _Context1.AdmLicenses.ToList();
            }

        public IEnumerable<AdmLicense> GetLicenses()
        {
            throw new NotImplementedException();
        }

        public List<ComProspection> GetProspection(Guid pkey)
        {
            throw new NotImplementedException();
        }

        public int InstallLicense(Guid id)
        {
            throw new NotImplementedException();
        }

        public int UserAvailable(User user)
            {
                AdmUser query = _Context1.AdmUsers.FirstOrDefault(a => a.Email == user.UserName);

                if (query is null)
                {
                    return 1;
                }
                if (query.Pass == user.Password)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }

        public List<AdmUser> VerifLicense(Guid pkey, string name, string pwd)
        {
            throw new NotImplementedException();
        }

        public bool AddProspection(string DateExpired, string MobileUsers, string ServerURL, string Description, string AdminEmail)
        {
            try
            {
                AdmLicense License = new();
                License.ServerUrl = ServerURL;
                License.Pkey = Guid.NewGuid();
                License.DateActivated = DateTime.Now;
                License.ExpireDate = DateTime.Parse(DateExpired);
                License.AdmUserEmail = AdminEmail;
                try
                {
                    License.AdmUserId = _Context1.AdmUsers.FirstOrDefault(a => a.Email == AdminEmail).Pkey;
                }
                catch (Exception)
                {

                    return false;
                }
               
                License.UserNumber = int.Parse(MobileUsers);
                License.Description = Description;

                _Context1.Add(License);
                _Context1.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
            
        }

        public AdmLicense GetSpecificLicense(string pkey)
        {
            try
            {
                return _Context1.AdmLicenses.Find(Guid.Parse(pkey));
            }
            catch (Exception e)
            {
                return null;
            }
            
            
        }

        public bool UpdateLicense(string pkey, string DateExpired, string MobileUsers, string ServerURL, string Description, string AdminEmail)
        {
            try
            {
                AdmLicense OldLicense = _Context1.AdmLicenses.Find(Guid.Parse(pkey));
                OldLicense.Description = Description;
                OldLicense.ExpireDate = Convert.ToDateTime(DateExpired);
                OldLicense.UserNumber = int.Parse(MobileUsers);
                OldLicense.ServerUrl = ServerURL;
                OldLicense.AdmUserEmail=AdminEmail;
                try
                {
                    OldLicense.AdmUserId = _Context1.AdmUsers.FirstOrDefault(a => a.Email == AdminEmail).Pkey;
                }
                catch (Exception)
                {

                    return false;
                }


                _Context1.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public int SendResetMail(string pkey, string email)
        {
            string url = _Context1.AdmLicenses.FirstOrDefault(a => a.Pkey == Guid.Parse(pkey)).ServerUrl;
            try
            {
                AdmUser User = Api.PostDeserializedAdmUser(url+ "GetUserByEmail", email);
                if (User is not null)
                {
                    string Link = Api.PostGeneratePasswordResetToken(url+ "ForgotPasswordResetMailTokenGenerator", email);
                    MailMessage mm = new("moifekmaiza2@gmail.com", email);
                    mm.Subject = "Password Recovery";                               // Must Decrypt before using this function for real
                    mm.Body = string.Format("Hi" + User.Description + ",<br /><br />Your password is " + User.Pass + " .<br /><br />Thank You.<br />or you can use" +
                        "this link to reset your password :"+ "Https://LocalHost:5003/Forgot-Password/"+Link+" <br />");
                    mm.IsBodyHtml = true;
                    SmtpClient smtpClient = new("smtp.gmail.com", Convert.ToInt32(587));
                    NetworkCredential credentials = new("moifekmaiza@gmail.com", "moifekgg122");
                    smtpClient.Credentials = credentials;
                    smtpClient.EnableSsl = true;
                    smtpClient.Send(mm);
                    return 0;
                }
                return 1;
            }
            catch (Exception)
            {
                return 2;
                throw;
            }
        }
        public int SetNewPassword(string code, string pwd, string email,string pkey)
        {
            string url = _Context1.AdmLicenses.Find(pkey).ServerUrl;
            try
            {
                AdmUser TempUser = new();
                TempUser.Code = code;
                TempUser.Pass = pwd;
                TempUser.Email = email;
                var result =Api.PostSerializedUserUpdate(url,TempUser).ToString();
                if(int.Parse(result) != 200)
                {
                    return 1; //User does not exist or problem with API (client side)
                   // throw ("User Does not Exist");
                }
                try
                {
                    Api.PostSerializedSetNewPassword(url+"SetNewPassword", TempUser);
                }
                catch (Exception)
                {
                    return 2; //Couldn't updated password
                    throw;
                }
                return 0; //found user and updated password
            }
            catch (Exception)
            {
                return 3; //Api problem
                throw;
            }
            
        }
    }
}
