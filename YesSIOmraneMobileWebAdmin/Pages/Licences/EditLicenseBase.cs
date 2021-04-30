using Microsoft.AspNetCore.Components;
using System;
using YesSIMobileModels.Models;
using System.Collections.Generic;
using System.Linq;
using YesSIOmraneMobileWebAdmin.API;
using System.Threading.Tasks;

namespace YesSIOmraneMobileWebAdmin.Pages.Licences
{
    public class EditLicenseBase : ComponentBase
    {

        [Inject]
        public NavigationManager NAV { get; set; }

        [Parameter]
        public string LicenseID { get; set; }
        public AdmLicense License { get; set; } = new AdmLicense();

        private ApiCaller Api { get; set; } = new("Https://Localhost:44386/");

        protected override async Task OnInitializedAsync()
        {
            License = await Api.GetSpecificLicense(LicenseID, "WebApi/GetSpecificLicense");
        }
        protected async Task UpdateEmployee()
        {
            await Api.UpdateLicense(License, "WebApi/UpdateLicense");
            NAV.NavigateTo("/List",false);
        }
        void cancel()
        {
            NAV.NavigateTo("/List",false);
        }


    }
}
