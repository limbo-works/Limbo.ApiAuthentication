﻿using Microsoft.Extensions.DependencyInjection;

namespace Limbo.ApiAuthentication.ApiKeys.Extentions {
    /// <summary>
    /// Extentions
    /// </summary>
    public static class ApiKeyExtentions {
        /// <summary>
        /// Adds api keys
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddApiKeys(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
