using System;
using brane.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace brane
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
            // services.AddDbContext<MyDbContext>(opt => opt.UseInMemoryDatabase("brane"));
            string connString = Configuration.GetConnectionString("connectionString");
            services.AddDbContext<MyDbContext>(opt => opt.UseMySql(connString,ServerVersion.AutoDetect(connString)));
            
            services.AddControllers();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IExigenceService, ExigenceService>();
            services.AddScoped<IJalonService, JalonService>();
            services.AddScoped<ITaskItemService, TaskItemService>();
            services.AddScoped<IUserService, UserService>();
            
            services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo {Title = "brane", Version = "v1"}); });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "brane v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}