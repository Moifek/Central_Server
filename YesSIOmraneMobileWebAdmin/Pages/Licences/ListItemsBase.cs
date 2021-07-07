using Microsoft.AspNetCore.Components;
using System;
using YesSIOmraneMobileWebAdmin.API;
using YesSIMobileModels.Models;
using System.Collections.Generic;
using YesSIOmraneMobileWebAdmin;
using System.Linq;
using System.Threading.Tasks;

namespace YesSIOmraneMobileWebAdmin.Pages.Licences
{
    public class ListItemsBase : ComponentBase
    {

        [Parameter]
        public string LicenseID { get; set; }

        protected Constants Const { get; set; } = new();

        protected AdmLicense License { get; set; } = new();

        private ApiCaller Api { get; set; }

        protected async Task OnIOnInitializedAsync()
        {
            Api = new ApiCaller(Const.URL);
            License = await Api.GetSpecificLicense(LicenseID, "GetSpecificLicense");
        }




    }
}
