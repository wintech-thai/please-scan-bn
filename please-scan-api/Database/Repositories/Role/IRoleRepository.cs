using Its.PleaseScan.Api.Models;

namespace Its.PleaseScan.Api.Database.Repositories
{
    public interface IRoleRepository
    {
        public void SetCustomOrgId(string customOrgId);
        public IEnumerable<MRole> GetRolesList(string rolesList);
    }
}
