using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using Taxas.Application.Taxas;

namespace Taxas
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddHealthChecks();
            ConfigureSwagger(services);
            ConfigureDependencyInjectionSettings(services);
        }

        public void ConfigureSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1.0",
                        new OpenApiInfo
                        {
                            Version = "v1.0",
                            Title = "Granito.Taxas",
                            Description = "API Calcula Taxas",
                            Contact = new OpenApiContact { Name = "Granito", Url = new Uri("https://granitopagamentos.com.br") }
                        }
                    );
            });

        }

        public void ConfigureDependencyInjectionSettings(IServiceCollection services)
        {
            //Clients
            services.AddLogging();

            //SINGLETON
            services.AddSingleton<IConfiguration>(Configuration);

            //TRANSIENT - Application            
            services.AddTransient<ITaxasApplication, TaxasApplication>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger().UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1.0/swagger.json", "Granito CalculaJuros v1");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
