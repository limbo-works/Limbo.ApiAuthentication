using Limbo.ApiAuthentication.Persistence.ApiKeys.Models;
using Limbo.ApiAuthentication.Persistence.Contexts;
using Limbo.EntityFramework.Repositories.Crud;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Limbo.ApiAuthentication.Persistence.ApiKeys.Repositories {
    /// <inheritdoc/>
    public class ApiKeyRepository : DbCrudRepositoryBase<ApiKey>, IApiKeyRepository {
        /// <inheritdoc/>
        public ApiKeyRepository(IDbContextFactory<ApiAuthenticationContext> contextFactory, ILogger<DbCrudRepositoryBase<ApiKey>> logger) : base(contextFactory, logger) {
        }
    }
}
