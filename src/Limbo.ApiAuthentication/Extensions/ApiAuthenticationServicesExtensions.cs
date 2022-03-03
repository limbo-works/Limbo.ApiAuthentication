using Limbo.ApiAuthentication.ApiClaims.Extensions;
using Limbo.ApiAuthentication.ApiKeys.Extensions;
using Limbo.ApiAuthentication.Authentication.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class ApiAuthenticationServicesExtensions {
        /// <summary>
        /// Adds api authentication services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddApiAuthenticationServices(this IServiceCollection services) {
            services
                .AddApiKeys()
                .AddAuthenticationServices()
                .AddApiClaims();

            return services;
        }
    }
}
