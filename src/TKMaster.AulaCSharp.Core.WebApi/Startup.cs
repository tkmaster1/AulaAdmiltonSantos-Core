using Microsoft.AspNetCore.Builder;
using TKMaster.AulaCSharp.Core.WebApi.Configurations;

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
            services.AddDependencyInjectionConfiguration();

            services.AddDatabaseConfiguration(Configuration);

            services.AddSwaggerGen(); // Tive adicionar isto para correção do erro da tela

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment webHost)
        {
            if (webHost.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Projeto de Ensino Core WebApi v1"));
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseCookiePolicy();

            app.UseCors
             (
                 c =>
                 {
                     c.AllowAnyOrigin();
                     c.AllowAnyHeader();
                     c.AllowAnyMethod();
                 }
             );

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("../swagger/v1/swagger.json", "Projeto de Ensino Core WebApi v1");
                s.RoutePrefix = "";
            });
        }

        #endregion
    }
}
