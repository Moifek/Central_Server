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
using Blazored.SessionStorage;


namespace YesSIOmraneMobileWebAdmin.Pages
{
    public class SignInBase : ComponentBase
    {
        protected string Day { get; set; } = DateTime.Now.DayOfWeek.ToString();

        public User User { get; set; } = new User();

        [Inject]
        protected NavigationManager NAV { get; set; }

        protected LoginUser LoginUser { get; set; } = new("Https://192.168.10.112:5001/");
        
        public  AuthentificatedUser auth = new AuthentificatedUser() ;
       public  bool errorMessage = false;
        private readonly ISessionStorageService _session;


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
                HttpResponseMessage query = await LoginUser.ConfirmLoginState(this.User, "WebApi/GetUserLogin");
              
                Console.WriteLine(query.StatusCode.ToString());
               
                                        
                    if(query.IsSuccessStatusCode)
                {
                    var rep = await query.Content.ReadAsStringAsync();
                    auth = JsonConvert.DeserializeObject<AuthentificatedUser>(rep);
              
                    
                    
                           await _session.SetItemAsStringAsync("user", auth.UserName);
                           await _session.SetItemAsStringAsync("role", auth.Role);


                    Console.WriteLine("reach");
                    NAV.NavigateTo("/List");
                   

                }
                else
                {
                    errorMessage = true;
                }

            }
            catch (Exception e)
            {
                errorMessage = true;
                Console.WriteLine("api problem",e);
                Console.WriteLine(e);

            }
            


        }

    }
}
