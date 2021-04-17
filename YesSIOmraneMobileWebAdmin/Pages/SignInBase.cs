using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components.Routing;
using System.Threading.Tasks;
using Newtonsoft.Json;
using YesSIOmraneMobileWebAdmin.API;
using Newtonsoft.Json.Converters;
using System.Net.Http;
using YesSIMobileModels.Models;
using System.Text;

namespace YesSIOmraneMobileWebAdmin.Pages
{
    public class SignInBase : ComponentBase
    {
        protected string Day { get; set; } = DateTime.Now.DayOfWeek.ToString();

        protected User User { get; set; } = new User();

        [Inject]
        protected NavigationManager NAV { get; set; }

        protected LoginUser LoginUser { get; set; } = new("https://localhost:44386"); 



        //protected async Task HandleLoginState(User _user)
        //{
        //    using HttpClient Login = new();


        //    var request = new HttpRequestMessage
        //    {
        //        Method = HttpMethod.Get,
        //        RequestUri = new Uri("https://192.168.1.103:5001/WebApi/Get?" +
        //                                "UserName=" + User.UserName.ToString() + "&Password=" + User.Password.ToString())
        //    };
        //    var response = await Login.SendAsync(request).ConfigureAwait(false);
        //    response.EnsureSuccessStatusCode();

        //    Login.Dispose();

        //}

        protected async void HandleLogin()
        {
            Console.WriteLine("reached HandleLogin");
            try
            {
                var query = await LoginUser.ConfirmLoginState(this.User, "WebApi/GetUserLogin");

                Console.WriteLine(query.StatusCode.ToString());
                Console.WriteLine(query);

                if (!(query.Content is null))
                {
                    NAV.NavigateTo("/List");
                    Console.WriteLine("reach");

                }
                else
                {
                    Console.WriteLine("api problem");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("api problem",e);
            }
            


        }

    }
}
