using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FirstASPNETWebAppHarris
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(); //This service allows us 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.UseDefaultFiles(); //goes to index.html automatically

            if (env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles(); //allows use of the index.html

            app.UseRouting(); //use of views and models

            app.UseEndpoints(endpoints =>  //where do we want to END up. Using a lambda function "endpoints"
            {
                endpoints.MapControllerRoute(
                    name: "default", //if it doesn't find any other routes... go to this one
                    pattern: "{controller=Blah}/{action=Index}/{id?}" //id means that its nullable, we dont HAVE to go there
                );
            });
        }
    }
}
