using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WRM.Context;
using WRM.Repositories;
using WRM.Services;

namespace WRM
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
            string ServerConnection = this.Configuration.GetConnectionString("SqlString");
            services.AddDbContext<WrmDbContext>(o => o.UseSqlServer(ServerConnection));
            services.AddControllers();
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            }
            );
            
            //services.AddDbContext<WrmDbContext>(item =>
            //item.UseSqlServer(Configuration.GetConnectionString("WRMConnection")));
            services.AddScoped<IPassengerService, PassengerService>();
            services.AddScoped<IPassengerRepo, PassengerRepo>();
            services.AddScoped<IStaffService, StaffService>();
            services.AddScoped<IStaffRepo, StaffRepo>();
            services.AddScoped<ISupervisorService, SupervisorService>();
            services.AddScoped<ISupervisorRepo, SupervisorRepo>();
            services.AddScoped<ISSRService, SSRService>();
            services.AddScoped<ISSRRepo, SSRRepo>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
