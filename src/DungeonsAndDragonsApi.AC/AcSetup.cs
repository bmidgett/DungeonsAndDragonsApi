using DungeonsAndDragonsApi.AC.DnD5e;
using DungeonsAndDragonsApi.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DungeonsAndDragonsApi.AC
{
    public static class AcSetup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            var provider = services.BuildServiceProvider();

            services.AddHttpClient<IDnD5eFacade, DnD5eFacade>(client =>
            {
                client.BaseAddress = new Uri("https://www.dnd5eapi.co/api/");
            });
            services.AddScoped<I5eDataService, DungeonsAndDragonsAdapter>();
        }
    }
}
