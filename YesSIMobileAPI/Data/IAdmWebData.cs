using System;
using System.Collections.Generic;
using System.Linq;
using YesSIMobileAPI.Models;
using System.Threading.Tasks;

namespace YesSIMobileAPI.Data
{
    public interface IAdmWebData
    {
        public SysResetPasswordAppRequest GetServerUrl(string token);
        public AuthentificatedUser UserAvailable(User user);
        public List<AdmLicense> GetLicensees();
        public void Delete(Guid id);
        public bool AddProspection(string DateExpired, string MobileUsers, string ServerURL, string Description, string AdminEmail);
        public AdmLicense GetSpecificLicense(string pkey);
        public bool UpdateLicense(string pkey, string DateExpired, string MobileUsers, string ServerURL, string Description, string AdminEmail);
        int SetNewPassword(string pwd, string pkey,string ID);
        int SendResetMail(string pkey, string email);
    }
}
