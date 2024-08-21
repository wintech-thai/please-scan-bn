using Its.PleaseScan.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Its.PleaseScan.Api.Database.Repositories
{
    public class WorkflowRepository : BaseRepository, IWorkflowRepository
    {
        public WorkflowRepository(IDataContext ctx)
        {
            context = ctx;
        }

        public MWorkFlow AddWorkflow(MWorkFlow workflow)
        {
            workflow.WorkflowId = Guid.NewGuid();
            workflow.CreatedDate = DateTime.UtcNow;
            workflow.OrgId = orgId;

            context!.Workflows!.Add(workflow);
            context.SaveChanges();

            return workflow;
        }
    }
}