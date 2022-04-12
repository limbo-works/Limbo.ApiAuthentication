using Limbo.ApiAuthentication.Persistence.ApiClaims.Models;
using Limbo.ApiAuthentication.Persistence.Contexts;
using Limbo.DataAccess.Repositories.Crud;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Limbo.ApiAuthentication.Persistence.ApiClaims.Repositories {
    /// <inheritdoc/>
    public class ApiClaimRepository : DbCrudRepositoryBase<ApiClaim>, IApiClaimRepository {
        /// <inheritdoc/>
        public ApiClaimRepository(IDbContextFactory<ApiAuthenticationContext> contextFactory, ILogger<DbCrudRepositoryBase<ApiClaim>> logger) : base(contextFactory, logger) {
        }
    }
}
