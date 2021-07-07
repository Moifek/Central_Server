using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using YesSIOmraneMobileWebAdmin.Widgets;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using YesSIOmraneMobileWebAdmin.API;
using System.Threading.Tasks;
using YesSIMobileModels.Models;

namespace YesSIOmraneMobileWebAdmin.Pages.Licences
{
    public class AddLicensesBase : ComponentBase
    {
        protected ConfirmBase ErrorMsg { get; set; }

        protected AdmLicense[] List2 { get; set; } = Array.Empty<AdmLicense>();
        protected Constants Const { get; set; } = new();

        protected AdmLicense License { get; set; } = new();

        protected ApiCaller Api;

        [Inject]
        protected NavigationManager NAV { get; set; }


        protected async void CreateEmployee()
        {
            if(License is not null) {
                try
                {
                    Api = new ApiCaller(Const.URL);
                    var query = await Api.AddLicense(License, "CreateLicense");
                    Console.WriteLine(query.StatusCode.ToString());
                    Console.WriteLine(query);

                    if (query.IsSuccessStatusCode)
                    {
                        NAV.NavigateTo("/List");
                        Console.WriteLine("reach");

                    }
                    else
                    {
                        ErrorMsg.Show();
                        Console.WriteLine("api problem");
                    }

                }
                catch (Exception e)
                {
                    ErrorMsg.Show();
                    Console.WriteLine("api problem", e);
                }

            }
            
        
           

        }


            private void cancel()
        {
            NAV.NavigateTo("/list");
        }
    }
}
