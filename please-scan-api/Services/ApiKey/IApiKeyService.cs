using Its.PleaseScan.Api.Models;
using Its.PleaseScan.Api.ModelsViews;

namespace Its.PleaseScan.Api.Services
{
    public interface IApiKeyService
    {
        public Task<MApiKey> GetApiKey(string orgId, string apiKey);
        public MVApiKey VerifyApiKey(string orgId, string apiKey);
        public MVApiKey? AddApiKey(string orgId, MApiKey apiKey);
        public MVApiKey? DeleteApiKeyById(string orgId, string keyId);
        public IEnumerable<MApiKey> GetApiKeys(string orgId);
    }
}
