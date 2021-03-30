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

        public int InstallLicense(Guid id)
        {
           
                AdmLicense query = _Context1.AdmLicenses.FirstOrDefault(a => a.Pkey == id);
                if (query == null) { return 1; }
                if (query.ExpireDate < DateTime.Now) { return 2;}
                else { return 0; }
            
        }

        public async Task<bool> Disconnect(Guid pkey)
        {
            AdmAppSession Session = _Context1.AdmAppSessions.Find(pkey);
            SysBlackListToken blackList = new();
            if(Session.State == true)
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




        public async Task<Guid?> AddSession(string Token, List<AdmUser> user, string[] info, Guid License)
        {
            AdmLicense _AdmLicense = _Context1.AdmLicenses.Find(License);
            AdmAppSession Session = new();
            AdmUser _User = user.FirstOrDefault();
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

        public List<AdmUser> VerifLicense(Guid pkey, string name, string pwd)
        {
            var License = _Context1.AdmLicenses.Find(pkey);
            if (License != null)
            {
                var item = (api.GetDeserializedReleases(License.ServerUrl + "Login?code=" + name + "&pwd=" + pwd));
                if (item != null) { return item; }

                return null;
            }
            else
                {
                return null;
            }
        }

        public List<ComProspection> GetProspection(Guid id)
        {
            var License = _Context1.AdmLicenses.Find(id);
            if (License != null)
            {
                var item = (api.GetDeserializedComProspections(License.ServerUrl + "GetProspections"));
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
    }
}
