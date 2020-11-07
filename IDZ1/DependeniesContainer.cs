using BusinessLogic.Abstractions;
using BusinessLogic.Implementations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Models.Settings;
using Ninject.Modules;
using System;
using System.Net.Http;

namespace IDZ1
{
    public class DependeniesContainer : NinjectModule
    {
        public override void Load()
        {
            ConfigureServices();
            ConfigureForms();
            ConfigureOptions();
        }

        private void ConfigureServices()
        {
            Bind<HttpClient>().To<HttpClient>();
            Bind<IRestClient>().To<RestClient>();
            Bind<IGoogleSearch>().To<GoogleSearch>().InTransientScope();
        }

        private void ConfigureForms()
        {
            Bind<MainForm>().To<MainForm>().InSingletonScope();
        }

        private void ConfigureOptions()
        {
            var configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();

            Bind<GoogleSearchSettings>().ToMethod(x => configuration.GetSection("GoogleSearchSettings").Get<GoogleSearchSettings>());
        }
    }
}
