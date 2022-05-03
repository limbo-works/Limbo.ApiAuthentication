using Limbo.ApiAuthentication.Persistence.ApiClaims.Models;
using Limbo.ApiAuthentication.Persistence.ApiClaims.Repositories;
using Limbo.EntityFramework.Services;
using Limbo.EntityFramework.Services.Crud;
using Limbo.EntityFramework.Settings;
using Limbo.EntityFramework.UnitOfWorks;
using Microsoft.Extensions.Logging;

namespace Limbo.ApiAuthentication.ApiClaims.Services {
    /// <inheritdoc/>
    public class ApiClaimsService : CrudServiceBase<ApiClaim, IApiClaimRepository>, IApiClaimService {
        /// <inheritdoc/>
        public ApiClaimsService(IApiClaimRepository repository, ILogger<ServiceBase<IApiClaimRepository>> logger, EntityFrameworkSettings entityFrameworkSettings, IUnitOfWork<IApiClaimRepository> unitOfWork) : base(repository, logger, entityFrameworkSettings, unitOfWork) {
        }
    }
}
