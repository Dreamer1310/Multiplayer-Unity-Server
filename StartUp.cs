using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using UnityMovementServer.Connection;

namespace UnityMovementServer
{
    public class StartUp
    {
        public IConfiguration Configuration { get; private set; }

        public StartUp(IConfiguration config)
        {
            Configuration = config;
        }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSignalR();

            services.AddControllers();

            services
                .AddDataProtection()
                .SetApplicationName("Here Comes Unity Server");

            services
                .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.Cookie.Name = ".Auth.Unity.Server";
                    options.ExpireTimeSpan = TimeSpan.FromHours(1);
                });
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();

            app.UseEndpoints(endpoint =>
            {

                app.UseAuthentication();

                app.UseAuthorization();


                endpoint.MapHub<GameHub>("/game");
                endpoint.MapControllerRoute(
                    name: "Api",
                    pattern: "api/{controller=Login}/{action=SignIn}/{id?}");
            });
        }
    }
}