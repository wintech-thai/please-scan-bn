using Its.PleaseScan.Api.Models;
using Its.PleaseScan.Api.ModelsViews;

namespace Its.PleaseScan.Api.Services
{
    public interface IUserService
    {
        public MVUser? AddUser(string orgId, MUser user);
        public IEnumerable<MUser> GetUsers(string orgId);
        public bool IsEmailExist(string orgId, string email);
        public bool IsUserNameExist(string orgId, string userName);
        public bool IsUserIdExist(string orgId, string userId);
        public MUser GetUserByName(string orgId, string userName);
    }
}
