using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using YesSIOmraneMobileWebAdmin.API;
using System.Threading.Tasks;
using YesSIMobileModels.Models;

namespace YesSIOmraneMobileWebAdmin.Pages.Services
{
    public class ForgotPasswordBase : ComponentBase
    {
        [Inject]
        public NavigationManager NAV { get; set; }
        protected ResetPasswordModel PasswordModel { get; set; } = new();
        [Parameter]
        public string Token { get; set; }
        protected AdmUser User { get; set; }
        private ApiCaller Api { get; set; } = new("Https://Localhost:44386/");

        protected async Task UpdatePassword(string password)
        {
            try
            {
                var row = await Api.GetServerUrl("WebApi/GetServerUrl", Token);
                try
                {
                    User.Pass = password;
                    User.Pkey = row.UserId;
                    var PassTask = await Api.UpdatePassword(User, "WebApi/SetNewPassword", row.ServerUrl);
                    NAV.NavigateTo("/List");
                }
                catch (Exception)
                {

                    throw;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
