using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.Persistence.ApiKeys.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class ApiKeyExtensions {
        /// <summary>
        /// Adds api keys
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddApiKeys(this IServiceCollection services) {
            services
                .AddRespositories();

            return services;
        }
    }
}
