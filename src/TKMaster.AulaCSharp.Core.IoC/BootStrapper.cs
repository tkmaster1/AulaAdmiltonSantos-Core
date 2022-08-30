using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TKMaster.AulaCSharp.Core.Data.Context;

namespace TKMaster.AulaCSharp.Core.IoC
{
    public static class BootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Lifestyle.Transient => Uma instância para cada solicitação
            // Lifestyle.Singleton => Uma instância única para a classe (para servidor)
            // Lifestyle.Scoped => Uma instância única para o request

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();

            #region Domain

            #endregion

            #region InfraData

            services.AddScoped<MeuContextoDB>();

            #endregion
        }
    }
}