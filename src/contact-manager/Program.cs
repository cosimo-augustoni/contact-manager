using contact_manager.Controller;
using contact_manager.View;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace contact_manager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            var serviceProvider = host.Services;

            Application.Run();
            var dashboardController = serviceProvider.GetRequiredService<DashboardController>();
            dashboardController.LoadView();
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services)=>
                {
                    services.AddView();
                    services.AddControllers();
                });
        }
    }
}