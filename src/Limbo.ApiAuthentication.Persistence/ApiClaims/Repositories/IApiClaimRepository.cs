using Limbo.ApiAuthentication.Persistence.ApiClaims.Models;
using Limbo.EntityFramework.Repositories.Crud;

namespace Limbo.ApiAuthentication.Persistence.ApiClaims.Repositories {
    /// <summary>
    /// A repository for interacting with api claims
    /// </summary>
    public interface IApiClaimRepository : IDbCrudRepositoryBase<ApiClaim> {
    }
}