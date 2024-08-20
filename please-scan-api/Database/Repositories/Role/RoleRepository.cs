using Its.PleaseScan.Api.Models;

namespace Its.PleaseScan.Api.Database.Repositories
{
    public class RoleRepository : BaseRepository, IRoleRepository
    {
        public RoleRepository(IDataContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<MRole> GetRolesList(string rolesList)
        {
            var list = rolesList.Split(',').ToList();
            var arr = context!.Roles!.Where(p => list.Contains(p.RoleName!)).ToList();

            return arr;
        }
    }
}