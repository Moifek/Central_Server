using System;
using System.Collections.Generic;
using System.Linq;
using YesSIMobileAPI.Models;
using RestSharp;
using YesSIMobileModels.Models2;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

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
        public List<ComProspection> GetDeserializedComProspections(string url,string criteria)
        {
            this.Client = new RestClient(url);
            var JsonToSend = JsonConvert.SerializeObject(criteria);
            var response = Client.Execute<List<ComProspection>>(new RestRequest().AddParameter("application/json; charset=utf-8", JsonToSend, ParameterType.RequestBody));

            if (response.Content == "") { return null; }

            else
            {
                return JsonConvert.DeserializeObject<List<ComProspection>>(response.Content);
            }
        }

        public List<ComProspectionKind> GetDeserializedComKinds(string url)
        {
            this.Client = new RestClient(url);
            var response = Client.Execute<List<ComProspectionKind>>(new RestRequest());

            if (response.Content == "") { return null; }

            else
            {
                return JsonConvert.DeserializeObject<List<ComProspectionKind>>(response.Content);
            }
        }

        public List<ComProspectionOrigin> GetDeserializedComOrigins(string url)
        {
            this.Client = new RestClient(url);
            var response = Client.Execute<List<ComProspectionOrigin>>(new RestRequest());

            if (response.Content == "") { return null; }

            else
            {
                return JsonConvert.DeserializeObject<List<ComProspectionOrigin>>(response.Content);
            }
        }


        public async Task<HttpStatusCode> PostSerializedProspections(string url, AddProspectionModel Prospections)
        {
            this.Client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            string jsonToSend = JsonConvert.SerializeObject(Prospections);
            request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;

            try
            {
                var result = await Client.ExecuteAsync(request);
                if (result.IsSuccessful)
                {
                    return HttpStatusCode.OK;
                }
                return HttpStatusCode.NotFound;
                
            }
            catch (Exception e)
            {
                return HttpStatusCode.BadRequest;
            }




        }

    }
}
