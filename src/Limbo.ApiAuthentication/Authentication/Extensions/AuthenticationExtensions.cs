using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.Authentication.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class AuthenticationExtensions {
        /// <summary>
        /// Adds authentication services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddAuthenticationServices(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
