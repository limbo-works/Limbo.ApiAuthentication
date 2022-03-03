using System;
using Microsoft.AspNetCore.Authorization;

namespace Limbo.ApiAuthentication.Extensions.Models {
    /// <summary>
    /// Settings for api configuration
    /// </summary>
    public class ApiAuthenticationConfigurationSettings {
        /// <summary>
        /// Provides programmatic configuration used by <see cref="IAuthorizationService"/> and <see cref="IAuthorizationPolicyProvider"/>
        /// </summary>
        public Action<AuthorizationOptions>? AuthorizationOptions { get; set; } = default;
        /// <summary>
        /// Configures what connection string to use to store data
        /// </summary>
        public string ConnectionStringKey { get; set; } = "Default";
        /// <summary>
        /// The configuration section for Limbo.ApiAuthentication
        /// </summary>
        public string ConfigurationSection { get; set; } = "Limbo:ApiAuthentication";
        /// <summary>
        /// The configuration section for Limbo.DataAccess
        /// </summary>
        public string DataAccessConfigurationSection { get; set; } = "Limbo:DataAccess";
    }
}
