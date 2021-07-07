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

        protected Constants Const { get; set; } = new();

        [Parameter]
        public string LicenseID { get; set; }
        public AdmLicense License { get; set; } = new AdmLicense();

        private ApiCaller Api { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Api = new ApiCaller(Const.URL);
            License = await Api.GetSpecificLicense(LicenseID, "GetSpecificLicense");
        }
        protected async Task UpdateEmployee()
        {
            Api = new ApiCaller(Const.URL);
            await Api.UpdateLicense(License, "UpdateLicense");
            NAV.NavigateTo("/List",false);
        }
        void cancel()
        {
            NAV.NavigateTo("/List",false);
        }


    }
}
