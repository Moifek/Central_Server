using System;
using YesSIMobileAPI.API;
using System.Collections.Generic;
using System.Linq;
using YesSIMobileAPI.Data;
using System.Threading.Tasks;
using YesSIMobileAPI.Models;
using YesSIMobileModels.Models2;
using System.Net.Mail;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit;
using MimeKit;
using System.Net;
using Microsoft.Extensions.Configuration;
using AdmRole =YesSIMobileAPI.Models.AdmRole;

namespace YesSIMobileAPI.Data
{
    public class MockWebApi : IAdmWebData
    {
            private readonly DBContextClass _Context1;
            private readonly ApiCall Api=new();
            private readonly IConfiguration configuration;

            public MockWebApi(DBContextClass db4, IConfiguration configuration)
            {
                _Context1 = db4;
                this.configuration = configuration;
             }

            public void Delete(Guid id)
            {
                AdmLicense License = _Context1.AdmLicenses.FirstOrDefault(x => x.Pkey == id);
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

        public AuthentificatedUser UserAvailable(User user)
            {
                AdmUser query = _Context1.AdmUsers.FirstOrDefault(a => a.Email == user.UserName && a.Pass==user.Password);
            var auth = new AuthentificatedUser();
            if (query is null)
                {
                auth.UserName = null;

                return auth;
                }
                else
                {
          
                auth.UserName = query.Pkey.ToString();
                AdmRole role = _Context1.AdmRoles.FirstOrDefault(a => a.Pkey == query.WebRoleId);
                auth.Role = role.Description;
                return auth;
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
                    if (_Context1.AdmUsers.FirstOrDefault(a => a.Email == AdminEmail) == null)
                    {
                        return false;
                    }
                    else
                    {
                        License.AdmUserId = _Context1.AdmUsers.FirstOrDefault(a => a.Email == AdminEmail).Pkey;
                    }
                    
                }
                catch (Exception)
                {
                    throw;
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
        public SysResetPasswordAppRequest GenerateResetPasswordUrl(string pkey, AdmUser _User)
        {
            try
            {
                AdmUser user = _User;
                if (user is not null)
                {
                    SysResetPasswordAppRequest request = new();
                    request.Id = Guid.NewGuid();
                    request.ServerUrl = _Context1.AdmLicenses.Find(Guid.Parse(pkey)).ServerUrl;
                    request.UserId = user.Pkey;
                    request.User = user;
                    request.ResetRequestDateTime = DateTime.Now;
                    request.Valid = true;
                    _Context1.SaveChanges();
                    return request;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        public int SendResetMail(string pkey, string email)
        {
            string url = _Context1.AdmLicenses.FirstOrDefault(a => a.Pkey == Guid.Parse(pkey)).ServerUrl;
            try
            {
                AdmUser User = Api.PostDeserializedAdmUser(url + "GetUserByEmail", email);
                if (User is not null)
                {
                    SysResetPasswordAppRequest table = GenerateResetPasswordUrl(pkey, User);
                    string Link = table.Id.ToString();
                    MailAddress from = new(configuration["EmailAdress"]);
                    MailAddress to = new(email);
                    MailMessage mm = new(from, to);
                    mm.Subject = "Password Recovery";                               // Must Decrypt before using this function for real
                    mm.Body = string.Format("Hi" + User.Description + ",<br /><br />Your password is " + User.Pass + " .<br /><br />Thank You.<br />or you can use" +
                        "this link to reset your password :" + "Https://192.168.1.102:5003/Forgot-Password/" + Link + " <br />");
                    mm.IsBodyHtml = true;
                    SmtpClient smtpClient = new("smtp.netfirms.com", Convert.ToInt32(465));
                    NetworkCredential credentials = new(configuration["EmailAdress"], configuration["EmailPassword"]);
                    smtpClient.UseDefaultCredentials = true;
                    smtpClient.Credentials = credentials;
                    smtpClient.EnableSsl = true;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
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
        public int SetNewPassword(string url, string pwd,string ID,string token)
        {
            
            try
            {
                AdmUser TempUser = new();
                TempUser.Pass = pwd;
                TempUser.Pkey = Guid.Parse(ID);
                TempUser.Code = "ttt";
                try
                {
                    Api.PostSerializedSetNewPassword(url+"SetNewPassword", TempUser);
                    _Context1.SysResetPasswordAppRequests.Find(Guid.Parse(token)).Valid = false;
                    _Context1.SaveChanges();
                    return 0;
                }
                catch (Exception)
                {
                    return 2; //Couldn't updated password
                    throw;
                }
            }
            catch (Exception)
            {
                return 3; //Api problem
                throw;
            }
            
        }
        public SysResetPasswordAppRequest GetServerUrl(string token)
        {
            try
            {
                Guid x = Guid.Parse(token);
                var result = _Context1.SysResetPasswordAppRequests.Find(x);
                return result;
                
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
    }
}
