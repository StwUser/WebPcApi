using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebPcApi.Implementation;
using WebPcApi.Interfaces;
using WebPcApi.Models;

namespace WebPcApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<PcsContext>();

            services.AddTransient<PcsContextSeedData>();

            //Add Screens
            services.AddScoped<IPcsRepository, PcsRepository>();

            services.AddScoped<IScreenService, ScreenService>();

            services.AddScoped<IMotherboardService, MotherboardService>();

            services.AddScoped<IMemoryService, MemoryService>();

            services.AddMemoryCache();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, PcsContextSeedData seeder)
        {
            // app.UseMiddleware<ExceptionHandlerMiddleware>();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

            });

            // seeder.EnsureSeedData().Wait(1000);
        }
    }
}
