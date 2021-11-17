using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace UnityMovementServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseUrls("http://localhost:5201")
                .UseStartup<StartUp>();
        }
    }
}
