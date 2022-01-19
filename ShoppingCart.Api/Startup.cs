using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using ShoppingCart.Repository.DataAccess;
using ShoppingCart.Repository.DBContext;
using ShoppingCart.Service.Interfaces;
using ShoppingCart.Service.Repository;
using ShoppingCart.Service.Services;

namespace ShoppingCart.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
     
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext(Configuration);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("api", new OpenApiInfo { Title = "ShoppingCart API", Version = "1.0" });
            });

            services.AddScoped<IBasketsService, BasketsService>();
            services.AddScoped<IBasketsRepository, BasketsRepository>();
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
                c.SwaggerEndpoint("/swagger/api/swagger.json", "ShoppingCart API v1");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
