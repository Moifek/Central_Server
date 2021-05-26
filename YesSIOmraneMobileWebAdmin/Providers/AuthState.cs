using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;

namespace YesSIOmraneMobileWebAdmin.Providers
{
    public class AuthState : AuthenticationStateProvider
    {
        private readonly HttpClient _httpClient;

        public AuthState (HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            //do the login HERE
            //Confirm login state server side
            //use user data from login to make an auth state

            var identity = new ClaimsIdentity(new[]
            {   new Claim(ClaimTypes.System,"11111"),
                new Claim(ClaimTypes.Name ,"Khaled"),
                new Claim(ClaimTypes.Role,"AdminYes")

          }, "auth"); 
            var claimPrincipal = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(claimPrincipal));
        }
    }
}

