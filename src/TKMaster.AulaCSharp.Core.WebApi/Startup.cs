using Microsoft.AspNetCore.Builder;

namespace TKMaster.AulaCSharp.Core.WebApi
{
    public class Startup
    {
        #region Properties

        public IConfiguration Configuration { get; set; }

        #endregion

        #region Constructor

        public Startup(IWebHostEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();

        }

        #endregion

        #region Methods

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc();
        }
               
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        } 
        
        #endregion
    }
}
