//using Microsoft.AspNetCore.Mvc;
//using System;
//using YesSIMobileAPI.Models;
//using YesSIMobileAPI.Data;
//using Newtonsoft.Json.Linq;
//using System.Text.Json;
//using YesSIMobileModels.Models2;
//using Microsoft.EntityFrameworkCore;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Authorization;
//using System.Net.Http;
//using System.Net;
//namespace YesSIMobileAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ActionsController : ControllerBase
//    {
//        private readonly IActionsData _iactions;

//        public ActionsController (IActionsData _iactions)
//        {
//            this._iactions = _iactions;
//        }

//        [HttpGet(nameof(getActions))]
//        public List<ComActionMessage> getActions(Guid user,string pkey)
//        {

//            return _iactions.getActions(user,pkey);

//        }
//        [HttpPost(nameof(addAction))]

//        public HttpStatusCode addAction(ComActionMessage action,string pkey)
//        {
//            return _iactions.addAction(action, pkey);

//        }

//        [HttpPost(nameof(updateAction))]

//        public HttpStatusCode updateAction(ComActionMessage action,string pkey)
//        {
//            return _iactions.updateAction(action, pkey);
           


//        }

//        [HttpGet(nameof(getComActionMessageTypes))]
//        public List<ComActionMessageType> getComActionMessageTypes(string pkey)
//        {

//            return _iactions.getComActionMessageTypes(pkey);


//        }

//    }
//}

