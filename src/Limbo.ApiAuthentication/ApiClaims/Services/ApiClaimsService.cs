using Limbo.ApiAuthentication.Persistence.ApiClaims.Models;
using Limbo.ApiAuthentication.Persistence.ApiClaims.Repositories;
using Limbo.DataAccess.Services;
using Limbo.DataAccess.Services.Crud;
using Limbo.DataAccess.Settings;
using Limbo.DataAccess.UnitOfWorks;
using Microsoft.Extensions.Logging;

namespace Limbo.ApiAuthentication.ApiClaims.Services {
    /// <inheritdoc/>
    public class ApiClaimsService : CrudServiceBase<ApiClaim, IApiClaimRepository>, IApiClaimService {
        /// <inheritdoc/>
        public ApiClaimsService(IApiClaimRepository repository, ILogger<ServiceBase<IApiClaimRepository>> logger, DataAccessSettings dataAccessSettings, IUnitOfWork<IApiClaimRepository> unitOfWork) : base(repository, logger, dataAccessSettings, unitOfWork) {
        }
    }
}
