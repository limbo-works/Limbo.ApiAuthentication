using Limbo.ApiAuthentication.Persistence.ApiKeys.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.Persistence.ApiKeys.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class RepositoryExtensions {
        /// <summary>
        /// Adds repositories
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddRespositories(this IServiceCollection services) {
            services
                .AddScoped<IApiKeyRepository, ApiKeyRepository>();

            return services;
        }
    }
}
