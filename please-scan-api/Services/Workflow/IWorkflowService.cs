using Its.PleaseScan.Api.Models;
using Its.PleaseScan.Api.ModelsViews;

namespace Its.PleaseScan.Api.Services
{
    public interface IWorkflowService
    {
        public MVWorkflow? AddWorkflow(string orgId, MWorkFlow workflow);
    }
}
