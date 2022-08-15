using Microsoft.Extensions.DependencyInjection;

namespace contact_manager.View
{
    internal static class ViewExtension
    {
        public static IServiceCollection AddView(this IServiceCollection services)
        {
            services.AddSingleton<IDashboardForm, DashboardForm>();

            return services;
        }
    }
}
