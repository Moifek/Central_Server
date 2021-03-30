using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using YesSIMobileAPI.Data;
using YesSIMobileAPI.Models;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace YesSIMobileAPI.Controllers
{
    [Route("api/[controller]")]  
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAdmLicenseData _admLicenseData;
        public AuthController(IAdmLicenseData _admLicenseData)
        {
            this._admLicenseData = _admLicenseData;
        }

        [HttpPost, Route("login")]
        public IActionResult Login(AdmUser user,Guid pkey)
        { 

            if (user == null)
            {
                return BadRequest("Invalid request");
            }

            int verif_License = _admLicenseData.InstallLicense(pkey);
            if (verif_License == 2)
            {
                return StatusCode(402);
            }
            else {

                List<AdmUser> verif = _admLicenseData.VerifLicense(pkey, user.Code, user.Pass);

                if (verif != null)
                {
                    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("KeyForSignInSecret@1234"));
                    var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                    var tokeOptions = new JwtSecurityToken(
                        issuer: "http://0.0.0.0:2000",
                        audience: "http://0.0.0.0:2000",
                        claims: new List<Claim>(),
                        expires: DateTime.Now.AddMinutes(480),
                        signingCredentials: signinCredentials
                    );

                    string[] info = { "test", "test" };

                    var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                    Guid? SessionPkey = _admLicenseData.AddSession(tokenString, verif , info, pkey).Result;
                    if(SessionPkey != null)
                    {
                        return Ok(new { Token = tokenString, user = verif, Session = SessionPkey });
                    }
                    else
                    {
                        return Conflict();
                    }
                    
                }
                else if (verif == null) 
                { 
                    return Unauthorized();
                }
                else
                {
                    return NotFound();
                }
            }

            
        }
    }
}
