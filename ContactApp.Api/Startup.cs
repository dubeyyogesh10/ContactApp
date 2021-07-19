using ContactApp.Infra.Database;
using ContactApp.Infra.Database.Config;
using ContactApp.Infra.Model;
using ContactApp.Repository.Queries;
using ContactApp.Repository.Services;
using ContactApp.Repository.Services.Interface;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ContactApp.Api
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

            services.AddDbContext<DataContext>((op) => op.UseSqlServer(Configuration["ConnectionString"]));
            services.AddTransient<IDbClient, DbClient>();

            services.AddTransient<IContactService, ContactService>();
            services.AddControllers();
            services.AddSwaggerGen();
            services.AddMediatR(typeof(GetContactByIdQuery).Assembly);
            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {



            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Contact API DEMO");
                c.RoutePrefix = string.Empty;
            });

            app.UseRouting();
            app.UseCors(options =>
            options.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader());

            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
