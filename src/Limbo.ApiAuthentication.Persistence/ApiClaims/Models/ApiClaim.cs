﻿using System.Collections.Generic;
using System.Security.Claims;
using Limbo.ApiAuthentication.Persistence.ApiKeys.Models;
using Limbo.EntityFramework.Models;

namespace Limbo.ApiAuthentication.Persistence.ApiClaims.Models {
    /// <summary>
    /// A api claim
    /// </summary>
    public class ApiClaim : IGenericId {
        /// <summary>
        /// The id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The type of claim
        /// </summary>
        public string? Type { get; set; }
        /// <summary>
        /// The value for a claim
        /// </summary>
        public string? Value { get; set; }

        /// <summary>
        /// The api keys using the claim
        /// </summary>
        public virtual ICollection<ApiKey>? ApiKeys { get; set; }

        /// <summary>
        /// Gets the claim as <see cref="Claim"/>
        /// </summary>
        /// <returns></returns>
        public Claim? GetClaim() {
            if (Type == null) {
                return null;
            }

            if (Value == null) {
                return null;
            }
            return new Claim(Type, Value);
        }
    }
}
