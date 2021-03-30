using System;
using System.Collections.Generic;
using System.Linq;
using YesSIMobileAPI.Data;
using System.Threading.Tasks;
using YesSIMobileAPI.Models;
using YesSIMobileModels.Models2;

namespace YesSIMobileAPI.Data
{
    public class MockWebApi : IAdmWebData
    {
            private readonly DBContextClass _Context1;

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

                if (query == null)
                {
                    return 1;
                }
                else if (query.Pass == user.Password)
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

        public AdmLicense VerifLicense2(Guid pkey, string name)
        {
            throw new NotImplementedException();
        }
    }
}
