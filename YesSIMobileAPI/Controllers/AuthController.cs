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
using Microsoft.Extensions.Configuration;

namespace YesSIMobileAPI.Controllers
{
    [Route("api/[controller]")]  
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAdmLicenseData _admLicenseData;
        private IConfiguration _config;
        public AuthController(IAdmLicenseData _admLicenseData, IConfiguration _config)
        {
            this._admLicenseData = _admLicenseData;
            this._config = _config;
        }

        [HttpPost, Route("login")]
        public IActionResult Login(AdmUser user,Guid pkey)
        { 

            if (user == null)
            {
                return BadRequest("Invalid request");
            }

            int verif_License = _admLicenseData.CheckLicense(pkey);
            if (verif_License == 2)
            {
                return StatusCode(402);
            }
            else {

                AdmUser verif = _admLicenseData.VerifLicense(pkey, user.Code, user.Pass);

                if (verif != null)
                {
                    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                    var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                    var tokeOptions = new JwtSecurityToken(
                        issuer: _config["Jwt:Issuer"],
                        audience: _config["Jwt:Issuer"],
                        null,
                        expires: DateTime.Now.AddMinutes(1400),
                        signingCredentials: signinCredentials
                    );

                    string[] info = { "test", "test" }; // IP + Mac Adress in table session

                    var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                    Guid? SessionPkey = _admLicenseData.AddSession(tokenString, verif, info, pkey).Result;
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
