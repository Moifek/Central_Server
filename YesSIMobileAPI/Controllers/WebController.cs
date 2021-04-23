using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using YesSIMobileAPI.Data;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using YesSIMobileAPI.Models;


namespace YesSIMobileAPI.Controllers
{

    [Route("WebApi")]
    [ApiController]
    public class WebController : ControllerBase
    {
        private readonly IAdmWebData _IAdmWebData;
        //private readonly AppSettings _appSettings;


        public WebController(IAdmWebData IAdmWebData)
        {
            _IAdmWebData = IAdmWebData;
        }

        [HttpDelete]
        [Route("DeleteLicense")]
        public IActionResult Delete(Guid id)
        {
            _IAdmWebData.Delete(id);
            return Ok("deleted");
        }

        [HttpGet]
        [Route("GetLicenseList")]
        public IEnumerable<AdmLicense> GetLicenseList()
        {
            return _IAdmWebData.GetLicensees();
        }

        /* public UsersController(AppSettings appSettings)
         {
             _appSettings = appSettings;
         }*/

        [HttpPost]
        [Route("GetUserLogin")]
        public IActionResult UserLogin(string Password, string UserName)
        {
            User user = new();
            user.UserName = UserName;
            user.Password = Password;
            if (_IAdmWebData.UserAvailable(user) == 0) { return Ok("Login"); }
            if (_IAdmWebData.UserAvailable(user) == 1) { return Unauthorized(); }
            if (_IAdmWebData.UserAvailable(user) == 2) { return Unauthorized(); }
            else { return Forbid(); }

        }

        [HttpPost(nameof(SetNewPassword))]
        public IActionResult SetNewPassword(string pkey, string code, string pwd, string email)
        {
            switch (_IAdmWebData.SetNewPassword(code,pwd,email,pkey))
            {
                case (0):
                    return Ok("User Found and updated !");
                    
                case (1):
                    return BadRequest("User not Found");
                case (2):
                    return Conflict("Couldn't updated password!");
                case (3):
                    return NotFound("API Problem !");
                default: return NoContent();
            }
        }

        //[HttpPost("authenticate")]
        //[AllowAnonymous]
        //public IActionResult Authenticate([FromBody] AuthUser user)
        //{
        //    var foundUser = Users.FirstOrDefault(u => u.UserName == user.UserName && u.Password == user.Password);
        //    if(foundUser == null)
        //    {

        //        return BadRequest(new { message = "User name or password invalid" });
        //    }

        //    var tokenHandler = new JwtSecurityTokenHandler();
        //    var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
        //    var claims = new Claim[]
        //    {
        //        new Claim("id",foundUser.Id.ToString()), 
        //        new Claim(ClaimTypes.Role,"admin")
        //    };

        //    var tokenDescriptor = new SecurityTokenDescriptor
        //    {
        //        Subject = new ClaimsIdentity(claims),
        //        Expires = DateTime.UtcNow.AddDays(1),
        //        SigningCredentials = new SigningCredentials(
        //            new SymmetricSecurityKey(key), 
        //            SecurityAlgorithms.HmacSha256Signature)
        //    };

        //    var securityToken = tokenHandler.CreateToken(tokenDescriptor);

        //    var returnUser = new User
        //    {
        //        Id = foundUser.Id,
        //        UserName = foundUser.UserName,
        //        FirstName = foundUser.FirstName,
        //        LastName = foundUser.LastName,
        //        GenderType = foundUser.GenderType,
        //        PhoneNumber = foundUser.PhoneNumber,
        //        Token = tokenHandler.WriteToken(securityToken)
        //    };

        //    return Ok(returnUser);
        //}


        [HttpPost (nameof(CreateLicense))]
        public IActionResult CreateLicense(string DateExpired, string MobileUsers, string ServerURL, string Description, string AdminEmail)
        {
            var result = _IAdmWebData.AddProspection(DateExpired, MobileUsers, ServerURL, Description, AdminEmail);
            if (result is false){
                return Unauthorized("Admin E-mail not found or bad request"); 
            }
            return Ok(result);
            
        }

        [HttpGet(nameof(GetSpecificLicense))]
        public IActionResult GetSpecificLicense(string pkey)
        {
            var result = _IAdmWebData.GetSpecificLicense(pkey);
            if (result is not null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost(nameof(UpdateLicense))]
        public IActionResult UpdateLicense(string pkey, string DateExpired, string MobileUsers, string ServerURL, string Description, string AdminEmail)
        {
            bool result = _IAdmWebData.UpdateLicense(pkey,DateExpired,MobileUsers,ServerURL,Description,AdminEmail);
            if (result)
            {
                return Ok("updated Successfully !");
            }
            else
            {
                return BadRequest("Something wrong happend !");
            }
        }
    }
}
