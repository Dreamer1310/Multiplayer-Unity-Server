using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace UnityMovementServer.Api.Controllers
{
    public class LoginController : ControllerBase
    {
        public static Int64 ID = 1;



        [HttpGet]
        public async Task<Boolean> SignIn()
        {
            try
            {
                var claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.NameIdentifier, ID.ToString()));
                ID++;
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principals = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(principals);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
         
        }
    }
}
