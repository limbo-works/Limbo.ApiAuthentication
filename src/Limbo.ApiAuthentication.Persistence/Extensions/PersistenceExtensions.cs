using Limbo.ApiAuthentication.Persistence.ApiClaims.Extensions;
using Limbo.ApiAuthentication.Persistence.ApiKeys.Extensions;
using Limbo.ApiAuthentication.Persistence.Contexts.Extensions;
using Limbo.EntityFramework.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.Persistence.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class PersistenceExtensions {
        /// <summary>
        /// Adds persistence layer
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="connectionStringKey"></param>
        /// <param name="entityFrameworkConfigurationSection"></param>
        /// <returns></returns>
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration, string connectionStringKey, string entityFrameworkConfigurationSection) {
            services
                .AddContexts(configuration, connectionStringKey)
                .AddApiKeys()
                .AddApiClaims()
                .AddEntityFramework(configuration, options => options.SettingsOptions.ConfigurationSection = entityFrameworkConfigurationSection);

            return services;
        }
    }
}
