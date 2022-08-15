using Microsoft.Extensions.DependencyInjection;

namespace contact_manager.Controller
{
    internal static class ControllerExtension
    {
        public static IServiceCollection AddControllers(this IServiceCollection services)
        {
            services.AddSingleton<DashboardController>();

            return services;
        }
    }
}
