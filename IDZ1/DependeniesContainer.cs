using BusinessLogic.Abstractions;
using BusinessLogic.Implementations;
using Microsoft.Extensions.Configuration;
using Models.Settings;
using Ninject.Modules;
using System.Net.Http;

namespace IDZ1
{
    public class DependeniesContainer : NinjectModule
    {
        public override void Load()
        {
            ConfigureServices();
            ConfigureForms();
            ConfigureApplicationSettings();
        }

        private void ConfigureServices()
        {
            Bind<HttpClient>().To<HttpClient>().InTransientScope();
            Bind<IRestClient>().To<RestClient>().InTransientScope();
            Bind<IGoogleSearchService>().To<GoogleSearchService>().InTransientScope();
            Bind<IGoogleTrendsService>().To<GoogleTrendsService>().InTransientScope();
            Bind<IBukvarixService>().To<BukvarixService>().InTransientScope();
        }

        private void ConfigureForms()
        {
            Bind<MainForm>().To<MainForm>().InSingletonScope();
        }

        private void ConfigureApplicationSettings()
        {
            var configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();

            Bind<GoogleSearchSettings>().ToMethod(x => configuration.GetSection("GoogleSearchSettings").Get<GoogleSearchSettings>());
            Bind<GoogleTrendsSettings>().ToMethod(x => configuration.GetSection("GoogleTrendsSettings").Get<GoogleTrendsSettings>());
            Bind<BukvarixSettings>().ToMethod(x => configuration.GetSection("BukvarixSettings").Get<BukvarixSettings>());
        }
    }
}
