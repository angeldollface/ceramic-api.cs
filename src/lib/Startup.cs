/*
CERAMIC-API.CS by Alexander Abraham a.k.a. "Angel Dollface".
Licensed under the MIT license.
*/

// Importing Microsoft's standard
// HTTTP API.
using Microsoft.AspNetCore.Http;

// Importing the API to build
// patterns.
using Microsoft.AspNetCore.Builder;

// Importing the API to build dependencies on
// the fly and support JIT compilation.
using Microsoft.Extensions.DependencyInjection;

// Declaring the namespace
// of the main app.
namespace CoreApp{

    // Declaring a handler
    // for the service
    // to start the app.
    public class Startup{

        // Configuring services by adding the MVC pattern.
        public void ConfigureServices(IServiceCollection services){
            services.AddMvc();
        }

        // The method for initial configuration and
        // app starting.
        public void Configure(IApplicationBuilder app){
            app.UseMvc();
            app.Run(
                context => {
                    return context.Response.WriteAsync(
                        "Put an IMEI number after my address!"
                    );
                }
            );

        }
    }
}