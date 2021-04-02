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

        AdmUser VerifLicense(Guid pkey, string name, string pwd);

        AdmLicense VerifLicense2(Guid pkey, string name);

        int CheckLicense(Guid id);

        IEnumerable<AdmLicense> GetLicenses();

        Task<Guid?> AddSession(string Token, AdmUser user, string[] info, Guid license);

        Task<bool> Disconnect(Guid pkey);

        HttpStatusCode AddProspection(AddProspectionModel Model, string pkey);

        List<ComProspectionOrigin> GetOrigin(string pkey);

        List<ComProspectionKind> GetKinds(string pkey);
        List<AdmTierTitle> GetAdmTitle(string pkey);
        List<CfgTranche> GetCfgTranche(string pkey);
        List<StkItemCategory> GetStkItemCategories(string pkey);
        List<StkItemType> GetStkItemTypes(string pkey);

        List<ComProspection> SearchProspections(string Criteria,string pkey);



    }

}
