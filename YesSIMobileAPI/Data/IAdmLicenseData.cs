using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using YesSIMobileAPI.Models;
using YesSIMobileModels.Models2;


namespace YesSIMobileAPI.Data
{
    public interface IAdmLicenseData
    {
        List<ComProspection> GetProspection(Guid pkey);

        List<AdmUser> VerifLicense(Guid pkey, string name, string pwd);

        AdmLicense VerifLicense2(Guid pkey, string name);

        int CheckLicense(Guid id);

        IEnumerable<AdmLicense> GetLicenses();

        Task<Guid?> AddSession(string Token, List<AdmUser> user, string[] info, Guid license);

        Task<bool> Disconnect(Guid pkey);

        HttpStatusCode AddProspection(AddProspectionModel Model, string pkey)

    }

}
