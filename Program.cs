using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using HotelBooking;



namespace HotelBooking
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = LoadConfiguration(args);
            var serviceProvider = ConfigureServices(config)
             .BuildServiceProvider();

            var app = serviceProvider.GetService<ConsoleApplication>();

             app.Run(args);
        }
        private static IServiceCollection ConfigureServices(IConfiguration config)
        {
            var services = new ServiceCollection();

          

            services.AddSingleton(config);

            services.AddTransient<ConsoleApplication>();
            services.AddTransient<IBookingManager, HotelBookingManager>();
          


            return services;
        }
        private static IConfiguration LoadConfiguration(string[] args)
        {
            var builder = new ConfigurationBuilder();

            return builder.Build();
        }
    }
}
