using Limbo.ApiAuthentication.Persistence.ApiClaims.Extensions;
using Limbo.ApiAuthentication.Persistence.ApiKeys.Extensions;
using Limbo.ApiAuthentication.Persistence.Contexts.Extensions;
using Limbo.DataAccess.Extensions;
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
        /// <param name="dataAccessConfigurationSection"></param>
        /// <returns></returns>
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration, string connectionStringKey, string dataAccessConfigurationSection) {
            services
                .AddContexts(configuration, connectionStringKey)
                .AddApiKeys()
                .AddApiClaims()
                .AddDataAccess(configuration, options => options.SettingsOptions.ConfigurationSection = dataAccessConfigurationSection);

            return services;
        }
    }
}
