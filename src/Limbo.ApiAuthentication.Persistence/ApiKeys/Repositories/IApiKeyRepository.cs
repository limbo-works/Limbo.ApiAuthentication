using Limbo.ApiAuthentication.Persistence.ApiKeys.Models;
using Limbo.EntityFramework.Repositories.Crud;

namespace Limbo.ApiAuthentication.Persistence.ApiKeys.Repositories {
    /// <summary>
    /// A repository for interacting with api keys
    /// </summary>
    public interface IApiKeyRepository : IDbCrudRepositoryBase<ApiKey> {
    }
}