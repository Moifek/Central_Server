using System;
using System.Collections.Generic;
using System.Linq;
using YesSIMobileAPI.Models;
using RestSharp;
using YesSIMobileModels.Models2;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YesSIMobileAPI.API
{
    public class ApiCall
    {
        RestClient Client;
        public List<AdmUser> GetDeserializedReleases(string url)
        {
            this.Client = new RestClient(url);
            var response = Client.Execute<List<AdmUser>>(new RestRequest());

            if (response.Content == "") { return null; }

            else
            {
                return response.Data;
            }
            
                 
        }

        public List<ComProspection> GetDeserializedComProspections(string url)
        {
            this.Client = new RestClient(url);
            var response = Client.Execute<List<ComProspection>>(new RestRequest());

            if (response.Content == "") { return null; }

            else
            {
                return JsonConvert.DeserializeObject<List<ComProspection>>(response.Content);
            }





        }

    }
}
