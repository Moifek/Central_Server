using System;
using System.Collections.Generic;
using System.Linq;
using YesSIMobileModels.Models;

using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Newtonsoft.Json;
using System.Text;
using System.Threading;

namespace YesSIOmraneMobileWebAdmin.API
{
    public class ApiCaller
    {
        HttpClient _HttpClient;
        private CancellationToken cancellationToken;

        public ApiCaller(string url)
        {
            this._HttpClient = new();
            _HttpClient.BaseAddress = new Uri(url);
        }

        public async Task<HttpResponseMessage> AddLicense(AdmLicense License, string Request)
        {
            HttpRequestMessage _Request = new HttpRequestMessage(HttpMethod.Post, _HttpClient.BaseAddress + Request + "?DateExpired=" + License.ExpireDate + "&MobileUsers=" + License.UserNumber + "&ServerURL=" + License.ServerUrl + "&Description=" + License.Description + "&AdminEmail=" + License.AdmUserEmail);

            var response = await _HttpClient.SendAsync(_Request);
            if (response.IsSuccessStatusCode)
            {
                if (response.Content.ToString() == "Admin E-mail not found or bad request")
                {
                    return null;
                }
                return response;
            }
            else
            {

                return null;
            }
            //_Request.Content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");


        }

        public async Task<AdmLicense[]> GetLicenseList(string request)
        {
            string _Request = _HttpClient.BaseAddress + request;
            return await _HttpClient.GetFromJsonAsync<AdmLicense[]>(_Request);
        }

        public async Task<AdmLicense> GetSpecificLicense(string pkey, string request)
        {
            string _Request = _HttpClient.BaseAddress + request + "?pkey=" + pkey;
            return await _HttpClient.GetFromJsonAsync<AdmLicense>(_Request);
        }
        public async Task<SysResetPasswordAppRequest> GetServerUrl(string request, string token)
        {
            string _Request = _HttpClient.BaseAddress + request + "?token=" + token;
            return await _HttpClient.GetFromJsonAsync<SysResetPasswordAppRequest>(_Request);
        }

        public async Task<HttpResponseMessage> UpdateLicense(AdmLicense License, string request)
        {

            string _Request = _HttpClient.BaseAddress + request + "?pkey=" + License.Pkey + "&DateExpired=" + License.ExpireDate + "&MobileUsers=" + License.UserNumber + "&ServerURL=" + License.ServerUrl + "&Description=" + License.Description + "&AdminEmail=" + License.AdmUserEmail;
            HttpRequestMessage FinalRequest = new(HttpMethod.Post, _Request);
            try
            {
                return await _HttpClient.SendAsync(FinalRequest);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public async Task<HttpResponseMessage> UpdatePassword(AdmUser user, string request, string url,string token)
        {
            string _Request = _HttpClient.BaseAddress + request + "?url=" + url + "&ID=" + user.Pkey + "&password=" + user.Pass + "&token=" + token ;
            HttpRequestMessage FinalRequest = new(HttpMethod.Post, _Request);
            try
            {
                return await _HttpClient.SendAsync(FinalRequest);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
