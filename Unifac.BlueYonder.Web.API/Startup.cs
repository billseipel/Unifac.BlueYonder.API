using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore;
using Swashbuckle.AspNetCore.Swagger;
using Unifac.BlueYonder.Library;
using Unifac.BlueYonder.Library.MocaHelper;
using Unifac.BlueYonder.Web.API.Controllers.Authentication;
using Unifac.BlueYonder.Web.API.Services;
using Unifac.BlueYonder.Web.API.Services.Helpers;
using Unifac.BlueYonder.Web.API.Services.Orders;
using Unifac.BlueYonder.Web.API.Services.Shipments;
using Unifac.BlueYonder.Web.API.Services.Users;
using Unifac.BlueYonder.Web.Library;

namespace Unifac.BlueYonder.Web.API
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
            ;
            //Configure the API to accept Headers
            services.AddMvc(options =>
            {
                options.RespectBrowserAcceptHeader = true; // false by default
            });
            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  builder =>
                                  {
                                      builder.WithOrigins("http://localhost:60976");
                                  });
            });
            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen();
            
            // Register the Library 
            services.AddTransient<IMocaDataHelper, MocaDataHelper>();
            services.AddTransient<IFormatMoca, FormatMoca>();
            services.AddTransient<IDataReaderHelper, DataReaderHelper>();

            //Register the Login Interface/controller
            services.AddTransient<ILoginController, LoginController>();

            // Register the associated Services
            services.AddTransient<IMocaService, MocaService>();
            services.AddTransient<IUsersService, UsersService>();
            services.AddTransient<IOrdersService, OrdersService>();
            services.AddTransient<IShipmentsService, ShipmentsService>();
           

            services.AddControllers();
            services.AddControllersWithViews()
                .AddNewtonsoftJson();
        }

        public void Configure(IApplicationBuilder app)
        {
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseCors(MyAllowSpecificOrigins);


            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
