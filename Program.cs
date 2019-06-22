using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace gnv_back
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            var port = Environment.GetEnvironmentVariable("PORT");

            return WebHost.CreateDefaultBuilder(args)
                // .UseUrls($"http://localhost:{port}/")
                .UseStartup<Startup>()
                .UseKestrel(options =>
                {
                    options.ListenAnyIP(Int32.Parse(string.IsNullOrEmpty(port) ? "5001" : port));
                });
        }
    }
}
