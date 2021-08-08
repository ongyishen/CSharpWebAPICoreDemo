using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace my_books
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                //Load Serilog config from appsetting.json
                //file
                //mssql
                var configuration = new ConfigurationBuilder()
                  .AddJsonFile("appsettings.json")
                  .Build();

                Log.Logger = new LoggerConfiguration()
                    .ReadFrom.Configuration(configuration)
                    .CreateLogger();

                //Apply Serilog
                //Log.Logger = new LoggerConfiguration()
                //    .WriteTo.File("Logs/log.txt", rollingInterval: RollingInterval.Day)
                //    .CreateLogger();

                CreateHostBuilder(args).Build().Run();
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .UseSerilog()//SERILOG
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}