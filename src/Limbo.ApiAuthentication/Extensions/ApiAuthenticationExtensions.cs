﻿using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Principal;
using System.Text;
using Limbo.ApiAuthentication.Extensions.Models;
using Limbo.ApiAuthentication.Persistence.Extensions;
using Limbo.ApiAuthentication.Settings.Extensions;
using Limbo.ApiAuthentication.Settings.Models;
using Limbo.ApiAuthentication.Tokens.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace Limbo.ApiAuthentication.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class ApiAuthenticationExtensions {
        /// <summary>
        /// Adds Limbo.ApiAuthentication
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddLimboApiAuthentication(this IServiceCollection services, IConfiguration configuration) {
            var defaultSettings = new ApiAuthenticationConfigurationSettings();
            return AddLimboApiAuthentication(services, configuration, defaultSettings);
        }

        /// <summary>
        /// Adds Limbo.ApiAuthentication
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        public static IServiceCollection AddLimboApiAuthentication(this IServiceCollection services, IConfiguration configuration, ApiAuthenticationConfigurationSettings settings) {
            services
                .AddSettings(configuration, settings.ConfigurationSection)
                .AddTokens()
                .AddPersistence(configuration, settings.ConnectionStringKey, settings.DataAccessConfigurationSection)
                .AddApiAuthenticationServices();

            if (settings.AuthorizationOptions == default) {
                services
                    .AddAuthorization();
            } else {
                services
                    .AddAuthorization(settings.AuthorizationOptions);
            }

            return services;
        }

        /// <summary>
        /// Adds console logs to help debug Jwt errors
        /// </summary>
        /// <param name="app"></param>
        /// <param name="bindJwtSettings"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseJwtDebug(this IApplicationBuilder app, ApiAuthenticationSettings bindJwtSettings) {
            app.Use(async (context, next) => {
                try {
                    if (context != null && context.User != null && context.User.Identity != null) {
                        Console.WriteLine(context.User.Identity.Name);
                        Console.WriteLine(context.User.Identity.IsAuthenticated);
                        var authToken = context.Request.Headers["Authorization"].ToString().Replace("Bearer ", string.Empty);
                        var tokenHandler = new JwtSecurityTokenHandler();
                        var validationParameters = new TokenValidationParameters() {
                            ValidateIssuerSigningKey = bindJwtSettings.ValidateAccessTokenSecretKey,
                            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(bindJwtSettings.AccessTokenSecret)),
                            ValidateIssuer = bindJwtSettings.ValidateIssuer,
                            ValidIssuer = bindJwtSettings.ValidIssuer,
                            ValidateAudience = bindJwtSettings.ValidateAudience,
                            ValidAudience = bindJwtSettings.ValidAudience,
                            RequireExpirationTime = bindJwtSettings.RequireExpirationTime,
                            ValidateLifetime = bindJwtSettings.RequireExpirationTime,
                            ClockSkew = TimeSpan.Zero
                        }; ;

                        IPrincipal principal = tokenHandler.ValidateToken(authToken, validationParameters, out SecurityToken validatedToken);
                        Console.WriteLine("Success: " + validatedToken);
                    }
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
                await next();
            });

            return app;
        }
    }
}
