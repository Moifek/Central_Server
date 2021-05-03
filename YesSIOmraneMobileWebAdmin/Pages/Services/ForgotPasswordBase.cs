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
        [Parameter]
        public string Token { get; set; }
        protected AdmUser user { get; set; }
        private ApiCaller Api { get; set; } = new("Https://Localhost:44386/");

        protected async Task UpdatePassword(string password)
        {
            try
            {
                var row = await Api.GetServerUrl("GetServerUrl",Token);
                try
                {
                    user.Pass = password;
                    user.Pkey = row.UserId;
                    var PassTask = await Api.UpdatePassword(user, "/SetNewPassword", row.ServerUrl.ToString());
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
