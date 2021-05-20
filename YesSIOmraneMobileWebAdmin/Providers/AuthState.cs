
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;

namespace YesSIOmraneMobileWebAdmin.Providers
{
    public class AuthState : AuthenticationStateProvider
    {
    
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
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

