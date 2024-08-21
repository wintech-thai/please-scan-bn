using Its.PleaseScan.Api.Models;
using Its.PleaseScan.Api.Database.Repositories;

namespace Its.PleaseScan.Api.Services
{
    public class RoleService : BaseService, IRoleService
    {
        private readonly IRoleRepository? repository = null;

        public RoleService(IRoleRepository repo) : base()
        {
            repository = repo;
        }

        public IEnumerable<MRole> GetRolesList(string orgId, string rolesList)
        {
            repository!.SetCustomOrgId(orgId);
            var result = repository!.GetRolesList(rolesList);

            return result;
        }
    }
}
