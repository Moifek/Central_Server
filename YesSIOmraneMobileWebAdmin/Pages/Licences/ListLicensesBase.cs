using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YesSIMobileModels.Models;
using YesSIOmraneMobileWebAdmin.API;

namespace YesSIOmraneMobileWebAdmin.Pages.Licences
{
    public class ListLicensesBase : ComponentBase
    {

        [Inject]
        public NavigationManager NAV { get; set; }

        protected Constants Const { get; set; } = new();

        public AdmLicense[] List2 { get; set; } = Array.Empty<AdmLicense>();

        private ApiCaller Api { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Api = new ApiCaller(Const.URL);
            List2 = await Api.GetLicenseList("GetLicenseList");
        }
    }
}
