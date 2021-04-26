using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using Newtonsoft.Json;
using YesSIMobileModels.Models;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;

namespace YesSIOmraneMobileWebAdmin.API
{
    public class LoginUser
    {
        HttpClient _HttpClient;
        public LoginUser(string url) 
        {
            this._HttpClient = new();
            _HttpClient.BaseAddress = new Uri(url);
        }

        public async Task<HttpResponseMessage> ConfirmLoginState(User user, String Request)
        {
            HttpRequestMessage _Request = new HttpRequestMessage(HttpMethod.Post, _HttpClient.BaseAddress+Request+"?Password="+user.Password+"&UserName="+user.UserName);
        
                var response = await _HttpClient.SendAsync(_Request);
                if (response.IsSuccessStatusCode)
                {
                    return response;
                }
                else
                {

                    return null;
                }
            //_Request.Content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");

            
        }

        public async Task<HttpResponseMessage> SetNewPassword(string Request, string code, string pwd, string email, string pkey)
        {
            if(email is not null)
            {
                pwd = null;
                code = null;
                HttpRequestMessage _Request = new HttpRequestMessage(HttpMethod.Post, _HttpClient.BaseAddress + Request + "?pkey=" + pkey + "&email=" + email);
                var response = await _HttpClient.SendAsync(_Request);
                if (response.IsSuccessStatusCode)
                {
                    return response;
                }
                else
                {

                    return null;
                }
            }
            return null;
        }

    }
}
