using Its.PleaseScan.Api.Models;

namespace Its.PleaseScan.Api.Services
{
    public interface IRoleService
    {
        public IEnumerable<MRole> GetRolesList(string orgId, string rolesList);
    }
}
