using System;
using System.Collections.Generic;
using System.Linq;
using YesSIMobileAPI.API;
using YesSIMobileModels.Models2;
using YesSIMobileAPI.Models;
using YesSIMobileAPI.Variables;
using System.Threading.Tasks;
using System.Net;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc;

namespace YesSIMobileAPI.Data
{
    public class MockAdmLiceseData : IAdmLicenseData
    {
        private readonly DBContextClass _Context1;

        private readonly ApiCall api = new();

        public MockAdmLiceseData(DBContextClass db4)
        {
            _Context1 = db4;
        }

        public int CheckLicense(Guid id)
        {

            AdmLicense query = _Context1.AdmLicenses.FirstOrDefault(a => a.Pkey == id);
            if (query == null) { return 1; }
            if (query.ExpireDate < DateTime.Now) { return 2; }
            else { return 0; }

        }

        public async Task<bool> Disconnect(Guid pkey)
        {
            AdmAppSession Session = _Context1.AdmAppSessions.Find(pkey);
            SysBlackListToken blackList = new();
            if (Session.State == true)
            {
                blackList.Id = Guid.NewGuid();
                blackList.Token = Session.Jwtoken;
                Session.Jwtoken = null;
                Session.State = false;
                Session.EndDate = DateTime.Now;
                Guid License = Guid.Parse(Session.Licensee.ToString());

                try
                {
                    _Context1.SysBlackListTokens.Add(blackList);
                    RefreshActiveUsers(License);
                    await _Context1.SaveChangesAsync();
                    return true;
                }
                catch
                {
                    return false;
                }


            }
            else
            {
                return false;
            }


        }

        private void RefreshActiveUsers(Guid License)
        {
            AdmLicense _License = _Context1.AdmLicenses.Find(License);
            _License.ActiveUserNumber--;
        }




        public async Task<Guid?> AddSession(string Token, AdmUser user, string[] info, Guid License)
        {

            AdmLicense _AdmLicense = _Context1.AdmLicenses.Find(License);
            AdmAppSession Session = new();
            AdmUser _User = user;
            Session.AppVersion = "1.0";
            Session.Jwtoken = Token;
            Session.Pkey = Guid.NewGuid();
            Session.StartDate = DateTime.Now;
            Session.Mac = info[0];
            Session.UserId = _User.Pkey;
            Session.State = true;
            Session.Ip = info[1];
            Session.Licensee = License;

            if (_AdmLicense.UserNumber <= _AdmLicense.ActiveUserNumber)
            {
                await _Context1.DisposeAsync();
                return null;
            }
            else
            {
                _AdmLicense.ActiveUserNumber++;
                _Context1.AdmAppSessions.Add(Session);
                await _Context1.SaveChangesAsync();

                return Session.Pkey;
            }
        }



        public IEnumerable<AdmLicense> GetLicenses()
        {
            return _Context1.AdmLicenses.ToList();
        }

        public AdmUser VerifLicense(Guid pkey, string name, string pwd)
        {
            var License = _Context1.AdmLicenses.Find(pkey);
            if (License != null)
            {
                var item = (api.PostNonSerializedLogin(License.ServerUrl + "Login?code=" + name + "&pwd=" + pwd));
                if (item != null) { return item; }

                return null;
            }
            else
            {
                return null;
            }
        }

        public List<Object> GetProspection(Guid id,int page,string user)
        {
            var License = _Context1.AdmLicenses.Find(id);
            if (License != null)
            {
                var item = (api.GetDeserializedComProspections(License.ServerUrl + "GetProspections"+"?page="+page+"&Id="+user));
                if (item != null) { return item; }

                return null;
            }
            else
            {
                return null;
            }
        }
        public AdmLicense VerifLicense2(Guid pkey, string name)
        {
            var x = _Context1.AdmLicenses.FirstOrDefault(a => a.AdmUserEmail == name && a.Pkey == pkey);

            if (x.ExpireDate > DateTime.Now)
            {

                return x;
            }
            else
            {
                return null;
            }

        }
        public HttpStatusCode AddProspection(AddProspectionModel Model, string pkey)
        {

            if (CheckLicense(Guid.Parse(pkey)) == 0)
            {
                string url = _Context1.AdmLicenses.FirstOrDefault(a => a.Pkey == Guid.Parse(pkey)).ServerUrl;
                var Status = (api.PostSerializedProspections(url + "AddProspection", Model));
                if (Status.IsCompletedSuccessfully)
                {
                    return Status.Result;
                }
                return Status.Result;
            }
            return HttpStatusCode.BadRequest;
        }


        public List<ComProspectionOrigin> GetOrigin(string pkey)
        {
            string url = _Context1.AdmLicenses.FirstOrDefault(a => a.Pkey == Guid.Parse(pkey)).ServerUrl;
            return api.GetDeserializedComOrigins(url + "GetComOrigins");
        }
        public List<ComProspectionKind> GetKinds(string pkey)
        {
            string url = _Context1.AdmLicenses.FirstOrDefault(a => a.Pkey == Guid.Parse(pkey)).ServerUrl;
            return api.GetDeserializedComKinds(url + "GetComKinds");
        }

        public List<ComProspection> SearchProspections(string Criteria, string pkey)
        {
            string url = _Context1.AdmLicenses.FirstOrDefault(a => a.Pkey == Guid.Parse(pkey)).ServerUrl;
            return api.GetDeserializedComProspections(url + "SearchProspectionList", Criteria);
        }

        public List<AdmTierTitle> GetAdmTitle(string pkey)
        {
            string url = _Context1.AdmLicenses.FirstOrDefault(a => a.Pkey == Guid.Parse(pkey)).ServerUrl;
            return api.GetDeserializedTierTitle(url + "GetAdmTierTitle");
        }

        public List<CfgTranche> GetCfgTranche(string pkey,string Id)
        {
            string url = _Context1.AdmLicenses.FirstOrDefault(a => a.Pkey == Guid.Parse(pkey)).ServerUrl;
            return api.GetDeserializedCfgTranche(url + "GetCfgTranche"+"&Id="+Id);
        }

        public List<StkItemCategory> GetStkItemCategories(string pkey)
        {
            string url = _Context1.AdmLicenses.FirstOrDefault(a => a.Pkey == Guid.Parse(pkey)).ServerUrl;
            return api.GetDeserializedItemCategory(url + "GetStkItemCategory");
        }

        public List<StkItemType> GetStkItemTypes(string pkey)
        {
            string url = _Context1.AdmLicenses.FirstOrDefault(a => a.Pkey == Guid.Parse(pkey)).ServerUrl;
            return api.GetDeserializedItemType(url + "GetStkItemTypes");
        }

        public Object Habilitation(string Id, string pkey)
        {
                if(CheckLicense(Guid.Parse(pkey)) == 0){

                string url = _Context1.AdmLicenses.FirstOrDefault(a => a.Pkey == (Guid.Parse(pkey))).ServerUrl;
                var Status = (api.GetDeserializedHabilitation(url + "Habilitation?Id=" + Id));
                if (CheckLicense(Guid.Parse(pkey)) == 0)
                {
                    if (Status is null)
                    {
                        return null;
                    }
                    return Status;
                }
                return null;
            }

            return null;

        }
        public Object Details(string tranche,string categ, string pkey)
        {
            string url = _Context1.AdmLicenses.Find(Guid.Parse(pkey)).ServerUrl;
            var Status = (api.GetDeserializedDetails(url + "details?categ=" + categ + "&tranche=" + tranche));
            if (CheckLicense(Guid.Parse(pkey)) == 0)
            {
                if (Status is null)
                {
                    return null;
                }
                return Status;
            }
            return null;

        }


        /**********************************************************/

        public HttpStatusCode addAction(ComActionMessage action, string pkey)
        {
            Guid Licence = Guid.Parse(pkey);
            string url = _Context1.AdmLicenses.Find(Licence).ServerUrl;
            ComActionMessage actionTrue = action;
            var Status = (api.PostSerializedAddComActions(url + "addAction", actionTrue));
            if (Status.IsCompletedSuccessfully)
            {
                return Status.Result;
            }
            return Status.Result;
        }
        public HttpStatusCode updateAction(ComActionMessage action, string pkey)
        {
            Guid Licence = Guid.Parse(pkey);
            string url = _Context1.AdmLicenses.Find(Licence).ServerUrl;
            var Status = (api.PostSerializedUpdateComActions(url + "addAction", action));
            if (Status.IsCompletedSuccessfully)
            {
                return Status.Result;
            }
            return Status.Result;
        }

        public List<ComActionMessage> getActions(Guid Id, string pkey)
        {
            Guid Licence = Guid.Parse(pkey);
            string url = _Context1.AdmLicenses.Find(Licence).ServerUrl;
            return api.GetDeserializedComActions(url + "getActions?user=" + Id);
        }

        public List<ComActionMessageType> getComActionMessageTypes(string pkey)
        {

            string url = _Context1.AdmLicenses.Find(Guid.Parse(pkey)).ServerUrl;
            return api.GetDeserializedComActionMessagetypes(url + "getComActionMessageTypes");
        }

    }
}

