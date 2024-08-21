using Its.PleaseScan.Api.Models;

namespace Its.PleaseScan.Api.Database.Repositories
{
    public interface IWorkflowRepository
    {
        public void SetCustomOrgId(string customOrgId);
        public MWorkFlow AddWorkflow(MWorkFlow workflow);
    }
}
