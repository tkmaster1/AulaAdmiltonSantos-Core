using Microsoft.EntityFrameworkCore;
using TKMaster.AulaCSharp.Core.Data.Context;

namespace TKMaster.AulaCSharp.Core.WebApi.Configurations
{
    public static class DatabaseConfig
    {
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddDbContext<MeuContextoDB>(
                options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
                );
        }
    }
}
