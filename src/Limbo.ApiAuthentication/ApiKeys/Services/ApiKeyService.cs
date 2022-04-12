using Limbo.ApiAuthentication.Persistence.ApiKeys.Models;
using Limbo.ApiAuthentication.Persistence.ApiKeys.Repositories;
using Limbo.DataAccess.Services;
using Limbo.DataAccess.Services.Crud;
using Limbo.DataAccess.Settings;
using Limbo.DataAccess.UnitOfWorks;
using Microsoft.Extensions.Logging;

namespace Limbo.ApiAuthentication.ApiKeys.Services {
    /// <inheritdoc/>
    public class ApiKeyService : CrudServiceBase<ApiKey, IApiKeyRepository>, IApiKeyService {
        /// <inheritdoc/>
        public ApiKeyService(IApiKeyRepository repository, ILogger<ServiceBase<IApiKeyRepository>> logger, DataAccessSettings dataAccessSettings, IUnitOfWork<IApiKeyRepository> unitOfWork) : base(repository, logger, dataAccessSettings, unitOfWork) {
        }
    }
}
