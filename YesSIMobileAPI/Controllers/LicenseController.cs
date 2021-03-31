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

        [HttpPost (nameof(AddProspection))]
        public HttpStatusCode AddProspection(AddProspectionModel Model, string pkey)
        {
          return _IAdmLicense.AddProspection(Model, pkey);
        }

        [HttpGet (nameof(GetOrigins))]
        public IActionResult GetOrigins(string pkey)
        {
            List<ComProspectionOrigin> Origins = _IAdmLicense.GetOrigin(pkey);
            if (!(Origins is null))
            {
                return NotFound(Origins);
            }
            return Ok(Origins);
        }

        [HttpGet(nameof(GetProspectionKinds))]
        public IActionResult GetProspectionKinds(string pkey)
        {
            List<ComProspectionKind> Kinds = _IAdmLicense.GetKinds(pkey);
            if (!(Kinds is null))
            {
                return NotFound(Kinds);
            }
            return Ok(Kinds);
        }

    }
}
