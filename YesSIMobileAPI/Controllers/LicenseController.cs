using Microsoft.AspNetCore.Mvc;
using System;
using YesSIMobileAPI.Models;
using YesSIMobileAPI.Data;
using Newtonsoft.Json.Linq;
using System.Text.Json;
using YesSIMobileModels.Models2;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http;
using System.Net;

namespace YesSIMobileAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LicenseController : ControllerBase
    {
        private readonly IAdmLicenseData _IAdmLicense;

        public LicenseController (IAdmLicenseData _IAdmLicense)
        {
            this._IAdmLicense = _IAdmLicense;
        }
       
        [HttpGet, Authorize]
        [Route("List")]
        public IEnumerable<AdmLicense> Get()
        {
            return _IAdmLicense.GetLicenses();
        }

        [HttpGet, Authorize]
        [Route("List3")]
        public AdmLicense Get3(Guid id, string name )
        {
            return _IAdmLicense.VerifLicense2(id, name);
        }

        [HttpGet, Authorize]
        [Route("GetProspection")]
        public IActionResult GetProspections(Guid id)
        {
            var query = _IAdmLicense.GetProspection(id);
            if ( query == null)
            {
                return NoContent();
            }
            else
            {
                return Ok(query);
            }
        }

        /* [HttpGet]
         [Route("List4")]
         public async Task<ICollection<Service.AdmUser>> Get4(string email, string name)
         {
             var x = new Service.Client("https://192.168.1.119:5001/", new HttpClient());
             return await x.LoginAsync(email, name);

         }*/



        [HttpGet]
        [Route("GetHasLicense")]
        [Produces("application/json")]
        public IActionResult GetHasLicense(Guid id)
        {

            var verif = _IAdmLicense.CheckLicense(id);

            
            if (verif == 0)
            {
                return Ok(true);
            }
            if (verif == 1)
            {
                return new UnauthorizedResult();
            }
            if (verif == 2){ return new StatusCodeResult(402);
            }
            else { return new BadRequestResult(); }
                              
        }

        [HttpPost]
        [Route("LogDisconnect")]
        public IActionResult LogDisconnect(string pkey)
        {
            Guid Pkey = Guid.Parse(pkey);
            if (_IAdmLicense.Disconnect(Pkey).Result == true)
            {
                return Ok("Disconnected and Logged Successfully");
            }
            else
            {
                return BadRequest("not logged successfully");
            }
        }

        [HttpPost (nameof(AddProspection)), Authorize]
        public HttpStatusCode AddProspection(AddProspectionModel Model, string pkey)
        {
          return _IAdmLicense.AddProspection(Model, pkey);
        }

        [HttpGet (nameof(GetProspectionOrigins)), Authorize]
        public IActionResult GetProspectionOrigins(string pkey)
        {
            List<ComProspectionOrigin> Origins = _IAdmLicense.GetOrigin(pkey);
            if ((Origins is null))
            {
                return NotFound(Origins);
            }
            return Ok(Origins);
        }

        [HttpGet(nameof(GetProspectionKinds)), Authorize]
        public IActionResult GetProspectionKinds(string pkey)
        {
            List<ComProspectionKind> Kinds = _IAdmLicense.GetKinds(pkey);
            if ((Kinds is null))
            {
                return NotFound(Kinds);
            }
            return Ok(Kinds);
        }

        [HttpGet(nameof(GetAdmTitles)), Authorize]
        public IActionResult GetAdmTitles(string pkey)
        {
            List<AdmTierTitle> Kinds = _IAdmLicense.GetAdmTitle(pkey);
            if ((Kinds is null))
            {
                return NotFound(Kinds);
            }
            return Ok(Kinds);
        }

        [HttpGet(nameof(GetCfgTranches)), Authorize]
        public IActionResult GetCfgTranches(string pkey)
        {
            List<CfgTranche> Kinds = _IAdmLicense.GetCfgTranche(pkey);
            if ((Kinds is null))
            {
                return NotFound(Kinds);
            }
            return Ok(Kinds);
        }

        [HttpGet(nameof(GetStkItemCategories)), Authorize]
        public IActionResult GetStkItemCategories(string pkey)
        {
            List<StkItemCategory> Kinds = _IAdmLicense.GetStkItemCategories(pkey);
            if ((Kinds is null))
            {
                return NotFound(Kinds);
            }
            return Ok(Kinds);
        }

        [HttpGet(nameof(GetStkItemTypes)), Authorize]
        public IActionResult GetStkItemTypes(string pkey)
        {
            List<StkItemType> Kinds = _IAdmLicense.GetStkItemTypes(pkey);
            if ((Kinds is null))
            {
                return NotFound(Kinds);
            }
            return Ok(Kinds);
        }

        [HttpPost (nameof(SearchProspection)), Authorize]
        public IActionResult SearchProspection(string criteria, string pkey)
        {
            if (_IAdmLicense.SearchProspections(criteria,pkey) is null)
            {
                return BadRequest();
            }
            return Ok(_IAdmLicense.SearchProspections(criteria, pkey));
        }


    }
}
