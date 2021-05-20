//using System;
//using System.Collections.Generic;
//using System.Linq;
//using YesSIMobileModels.Models;
//using YesSIMobileAPI.API;
//using System.Threading.Tasks;
//using YesSIMobileAPI.Data;
//using YesSIMobileModels.Models2;
//using System.Net;

//namespace YesSIMobileAPI.Data
//{
//    public class MockActionsData : IActionsData
//    {
//        private readonly DBContextClass _Context1;

//        private readonly ApiCall api = new();


//        public MockActionsData(DBContextClass db4)
//        {
//            this._Context1 = db4;
//        }

//        public HttpStatusCode addAction(ComActionMessage action, string pkey)
//        {
//            Guid Licence = Guid.Parse(pkey);
//            string url = _Context1.AdmLicenses.Find(Licence).ServerUrl;
//            var Status = (api.PostSerializedAddComActions(url + "addAction", action));
//            if (Status.IsCompletedSuccessfully)
//            {
//                return Status.Result;
//            }
//            return Status.Result;
//        }
//        public HttpStatusCode updateAction(ComActionMessage action, string pkey)
//        {
//            Guid Licence = Guid.Parse(pkey);
//            string url = _Context1.AdmLicenses.Find(Licence).ServerUrl;
//            var Status = (api.PostSerializedUpdateComActions(url + "addAction", action));
//            if (Status.IsCompletedSuccessfully)
//            {
//                return Status.Result;
//            }
//            return Status.Result;
//        }

//        public List<ComActionMessage> getActions(Guid user,string pkey)
//        {
//            Guid Licence = Guid.Parse(pkey);
//            string url = _Context1.AdmLicenses.Find(Licence).ServerUrl;
//            return api.GetDeserializedComActions(url+ "getActions");
//        }

//        public List<ComActionMessageType> getComActionMessageTypes(string pkey)
//        {
           
//            string url = _Context1.AdmLicenses.Find(Guid.Parse(pkey)).ServerUrl;
//            return api.GetDeserializedComActionMessagetypes(url + "getComActionMessageTypes");
//        }
//    }
//}
