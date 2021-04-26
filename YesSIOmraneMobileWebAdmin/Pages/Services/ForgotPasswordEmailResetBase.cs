using System;
using System.Collections.Generic;
using System.Linq;
using YesSIMobileModels.Models;
using System.Threading.Tasks;
using YesSIOmraneMobileWebAdmin.API;
using Microsoft.AspNetCore.Components;

namespace YesSIOmraneMobileWebAdmin.Pages.Services
{
    public class ForgotPasswordEmailResetBase : ComponentBase
    {
        protected ForgotPasswordModel Email { get; set; } = new();
        protected LoginUser Api { get; set; }
        protected string Pkey { get; set; }

        protected string GenerateResetToken()
        {
            var response = Api.SetNewPassword("/SetNewPassword", null, null, Email.Email, Pkey);
            if (response.IsCompletedSuccessfully)
            {
                return "great!";
            }
            return "not great!!";
        }
    }
}
