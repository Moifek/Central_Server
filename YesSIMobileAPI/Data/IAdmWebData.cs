using System;
using System.Collections.Generic;
using System.Linq;
using YesSIMobileAPI.Models;
using System.Threading.Tasks;

namespace YesSIMobileAPI.Data
{
    public interface IAdmWebData
    {
        public int UserAvailable(User user);
        public List<AdmLicense> GetLicensees();
        public void Delete(Guid id);
    }
}
