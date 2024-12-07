using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace PizzaOrderApp
{

    public class Server 
    {
        /// <summary>
        /// This is the entry point of our web app
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args) 
        {
            // sets up the web server
            // Build() compiles the server config
            // Run() starts the server and starts listening to requests
            CreateHostBuilder(args).Build().Run(); 
        }

        /// <summary>
        /// Configures the web host
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            // CreateDefaultBuilder sets up logging and configuration for our app settings
            // ConfigureWebHostDefaults uses the helper function ConfigureWebHost to define server behavior
            return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(ConfigureWebHost);
        }

        /// <summary>
        /// States that the Startup class will define how the app is set up
        /// </summary>
        /// <param name="webBuilder"></param>
        private static void ConfigureWebHost(IWebHostBuilder webBuilder)
        {
            webBuilder.UseStartup<Startup>();
        }
    }

    /// <summary>
    /// Contains the main setup for our app
    /// </summary>
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Register services needed for controllers and views
            services.AddControllersWithViews();
        }

        /// <summary>
        /// Defines middleware pipeline and routing behavior
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // if in development, enable the developer exception page
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // allows the app to map URLs to endpoints
            app.UseRouting();

            // defines our endpoints
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

    }

}