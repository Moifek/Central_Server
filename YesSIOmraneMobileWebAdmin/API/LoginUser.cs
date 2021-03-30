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
            HttpRequestMessage _Request = new HttpRequestMessage(HttpMethod.Post, Request);
            //_Request.Content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");

            var response = await _HttpClient.SendAsync(_Request);
            if (response.IsSuccessStatusCode == true)
            {
                return response;
            }
            else
            {
                HttpResponseMessage ex = new();
                return ex;
            }
        }

    }
}
