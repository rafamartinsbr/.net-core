using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OrderModule.Contracts;
using OrderModule.DataAccess;
using OrderModule.Logics;
using Swashbuckle.AspNetCore.Swagger;

namespace OrderModule.Web.Api
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
            services.AddMvc();

            // Register the Swagger generator, defining one or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "OrderModule API", Version = "v1" });
            });

            services.AddTransient(typeof(IOrderQueries), typeof(OrderQueries));
            services.AddTransient(typeof(IOrderCommands), typeof(OrderCommands));
            //services.AddTransient(typeof(IOrderDataAccess), typeof(SqlOrderDataAccess));
            services.AddSingleton(typeof(IOrderDataAccess), typeof(InMemoryOrderDataAccess));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Book API V1");
            });

            app.UseMvc();
        }
    }
}