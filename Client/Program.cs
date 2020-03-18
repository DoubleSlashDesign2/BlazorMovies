using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorMovies.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            ConfigureServices(builder.Services); // configured our services with DependencyInjection

            await builder.Build().RunAsync();
        }

        // configured our services with DependencyInjection - on client site used program.cs class on server use startup.cs
        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions(); // Used for - Authorization System 
            services.AddSingleton<SingletonService>();
            services.AddTransient<Transientservice>();
        }

    }
}
