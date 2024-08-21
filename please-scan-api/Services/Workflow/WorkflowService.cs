using Its.PleaseScan.Api.Models;
using Its.PleaseScan.Api.ModelsViews;
using Its.PleaseScan.Api.Database.Repositories;
using Its.PleaseScan.Api.Utils;

namespace Its.PleaseScan.Api.Services
{
    public class WorkflowService : BaseService, IWorkflowService
    {
        private readonly IWorkflowRepository? repository = null;
        private DateTime compareDate = DateTime.Now;

        public WorkflowService(IWorkflowRepository repo) : base()
        {
            repository = repo;
        }

        public void SetCompareDate(DateTime dtm)
        {
            //For unit testing injection
            compareDate = dtm;
        }

        public MVWorkflow? AddWorkflow(string orgId, MWorkFlow workflow)
        {
            repository!.SetCustomOrgId(orgId);

            var r = new MVWorkflow();
/*
            var t = repository!.GetApiKey(apiKey.ApiKey!);
            var m = t.Result;

            if (m != null)
            {
                r.Status = "DUPLICATE";
                r.Description = "API Key is duplicate";

                return r;
            }

            var result = repository!.AddApiKey(apiKey);

            r.Status = "OK";
            r.Description = "Success";
            r.ApiKey = result;
*/
            return r;
        }
    }
}
