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
        public ApiCall()
        {
          
        }

        public AdmUser PostNonSerializedLogin(string url)
        {
            this.Client = new RestClient(url);
            var response = Client.Execute<AdmUser>(new RestRequest());

            if (response.Content == "") { return null; }

            else
            {
                return response.Data;
            }
            
                 
        }
        public List<AddProspectionModel> GetDeserializedComProspections(string url)
        {
            this.Client = new RestClient(url);
            var response = Client.Execute<List<AddProspectionModel>>(new RestRequest());

            if (response.Content == "") { return null; }

            else
            {
                return JsonConvert.DeserializeObject<List<AddProspectionModel>>(response.Content);
            }
        }
        public List<ComProspection> GetDeserializedComProspections(string url,string criteria)
        {
            this.Client = new RestClient(url+ "?Criteria="+criteria);
            var response = Client.Execute<List<ComProspection>>(new RestRequest());

            if(response.Content == "")
            {
                
                return null;
            }
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
        public List<CfgTranche> GetDeserializedCfgTranche(string url)
        {
            this.Client = new RestClient(url);
            var response = Client.Execute<List<CfgTranche>>(new RestRequest());

            if (response.Content == "") { return null; }

            else
            {
                return JsonConvert.DeserializeObject<List<CfgTranche>>(response.Content);
            }
        }
        public List<AdmTierTitle> GetDeserializedTierTitle(string url)
        {
            this.Client = new RestClient(url);
            var response = Client.Execute<List<AdmTierTitle>>(new RestRequest());

            if (response.Content == "") { return null; }

            else
            {
                return JsonConvert.DeserializeObject<List<AdmTierTitle>>(response.Content);
            }
        }
        public List<StkItemCategory> GetDeserializedItemCategory(string url)
        {
            this.Client = new RestClient(url);
            var response = Client.Execute<List<StkItemCategory>>(new RestRequest());

            if (response.Content == "") { return null; }

            else
            {
                return JsonConvert.DeserializeObject<List<StkItemCategory>>(response.Content);
            }
        }
        public List<StkItemType> GetDeserializedItemType(string url)
        {
            this.Client = new RestClient(url);
            var response = Client.Execute<List<StkItemType>>(new RestRequest());

            if (response.Content == "") { return null; }

            else
            {
                return JsonConvert.DeserializeObject<List<StkItemType>>(response.Content);
            }
        }
        public List<AdmUser> GetDeserializedAdmUsers(string url)
        {
            this.Client = new RestClient(url);
            var response = Client.Execute<List<AdmUser>>(new RestRequest());

            if (response.Content == "") { return null; }

            else
            {
                return JsonConvert.DeserializeObject<List<AdmUser>>(response.Content);
            }
        }
        public AdmUser PostDeserializedAdmUser(string url, string email)
        {
            this.Client = new RestClient(url+"?email="+email);
            var response = Client.Execute<AdmUser>(new RestRequest());

            if (response.Content == "") { return null; }

            else
            {
                return JsonConvert.DeserializeObject<AdmUser>(response.Content);
            }
        }
        //public string PostGeneratePasswordResetToken(string url, string email)
        //{
        //    this.Client = new RestClient(url + "?email=" + email);
        //    var response = Client.Execute<string>(new RestRequest());

        //    if (response.Content == "") { return null; }

        //    else
        //    {
        //        return JsonConvert.DeserializeObject<string>(response.Content);
        //    }
        //}
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
        public async Task<HttpStatusCode> PostSerializedUserUpdate(string url, AdmUser TempUser)
        {
            this.Client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            string jsonToSend = JsonConvert.SerializeObject(TempUser);
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
        public HttpStatusCode PostSerializedSetNewPassword(string url, AdmUser TempUser)
        {
            this.Client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            string jsonToSend = JsonConvert.SerializeObject(TempUser);
            request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;
            try
            {
                var result =  Client.Execute(request);
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
