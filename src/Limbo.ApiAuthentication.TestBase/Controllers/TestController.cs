using Limbo.ApiAuthentication.ApiKeys.Services;
using Limbo.ApiAuthentication.Authentication.Services;
using Limbo.ApiAuthentication.Persistence.ApiKeys.Models;
using Limbo.ApiAuthentication.Tokens.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Limbo.ApiAuthentication.TestBase.Controllers {
    [ApiController]
    [Route("[controller]/[action]")]
    public class TestController : ControllerBase {
        private readonly IApiKeyAuthenticatorService _authenticationService;
        private readonly IApiKeyService _apiKeyService;

        public TestController(IApiKeyAuthenticatorService authenticationService, IApiKeyService apiKeyService) {
            _authenticationService = authenticationService;
            _apiKeyService = apiKeyService;
        }

        [HttpGet(Name = "Authenticate")]
        public async Task<ApiToken> Authenticate(string apiKey) {
            return await _authenticationService.AuthenticateKey(apiKey);
        }

        [HttpGet(Name = "TestAuthenticationToken")]
        [Authorize]
        public string TestAuthenticationToken() {
            return "You Are Authenticated";
        }

        [HttpGet(Name = "CreateApiKey")]
        [Authorize]
        public async Task<ApiKey?> CreateApiKey(string apiKey) {
            return (await _apiKeyService.Add(new ApiKey { Key = apiKey })).ResponseValue;
        }

        [HttpGet(Name = "CreateApiKeyUnAuthorized")]
        public async Task<ApiKey?> CreateApiKeyUnAuthorized(string apiKey) {
            return (await _apiKeyService.Add(new ApiKey { Key = apiKey })).ResponseValue;
        }
    }
}
