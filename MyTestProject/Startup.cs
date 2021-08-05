using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyTestProject.Services;
using System;

namespace MyTestProject
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services, HostBuilderContext context)
        {
            Console.WriteLine($"ConfigureServices: curdir={Environment.CurrentDirectory}");

            services.AddSingleton<IMyService, MyService>();
        }

        public IHostBuilder CreateHostBuilder() => Host.CreateDefaultBuilder();

        public void ConfigureHost(IHostBuilder hostBuilder) => hostBuilder.ConfigureAppConfiguration(ConfigureAppConfiguration);

        public void ConfigureAppConfiguration(HostBuilderContext context, IConfigurationBuilder builder)
        {
            Console.WriteLine($"ConfigureAppConfiguration: curdir={Environment.CurrentDirectory}");
            builder.AddJsonFile("appsettings.json");
        }
    }
}
