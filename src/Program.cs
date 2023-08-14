/*
CERAMIC-API.CS by Alexander Abraham a.k.a. "Angel Dollface".
Licensed under the MIT license.
*/

// Importing the generic
// sytem API.
using System;

// Importing Microsoft's API
// for starting a server.
using Microsoft.AspNetCore.Hosting;

// Declaring the namespace
// of the main app.
namespace CoreApp {

    // The main point-of-entry
    // class for the C# compiler.
    class Program {

        // The main point of entry for the C#
        // compiler.
        static void Main(string[] args) {
            Console.WriteLine("Starting app.");
            var host = new WebHostBuilder()
            .UseKestrel()
            .UseStartup<Startup>()
            .Build();

            host.Run();
        }

    }
}