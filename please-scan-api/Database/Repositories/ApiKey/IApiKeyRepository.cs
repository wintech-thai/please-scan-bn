using Its.PleaseScan.Api.Models;

namespace Its.PleaseScan.Api.Database.Repositories
{
    public interface IApiKeyRepository
    {
        public void SetCustomOrgId(string customOrgId);
        public Task<MApiKey> GetApiKey(string apiKey);
        public MApiKey AddApiKey(MApiKey apiKey);
        public MApiKey? DeleteApiKeyById(string keyId);
        public IEnumerable<MApiKey> GetApiKeys();
    }
}
