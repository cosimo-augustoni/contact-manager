using Microsoft.Extensions.DependencyInjection;

namespace contact_manager.View
{
    internal static class ViewExtension
    {
        public static IServiceCollection AddView(this IServiceCollection services)
        {
            services.AddTransient<Form1>();

            return services;
        }
    }
}
