using Microsoft.AspNetCore.Components;
using System;
using YesSIOmraneMobileWebAdmin.API;
using YesSIMobileModels.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YesSIOmraneMobileWebAdmin.Pages.Licences
{
    public class ListItemsBase : ComponentBase
    {

        [Parameter]
        public string LicenseID { get; set; }

        protected AdmLicense License { get; set; } = new();

        private ApiCaller Api { get; set; } = new("https://192.168.1.8:5001/");

        protected async Task OnIOnInitializedAsync()
        {
            License = await Api.GetSpecificLicense(LicenseID, "WebApi/GetSpecificLicense");
        }




    }
}
