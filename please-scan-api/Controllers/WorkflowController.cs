using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Its.PleaseScan.Api.Models;
using Its.PleaseScan.Api.Services;

namespace Its.PleaseScan.Api.Controllers
{
    [Authorize(Policy = "GenericRolePolicy")]
    [ApiController]
    [Route("/api/[controller]")]
    public class WorkflowController : ControllerBase
    {
        private readonly IWorkflowService svc;

        [ExcludeFromCodeCoverage]
        public WorkflowController(IWorkflowService service)
        {
            svc = service;
        }

        [ExcludeFromCodeCoverage]
        [HttpPost]
        [Route("org/{id}/action/AddWorkflow")]
        public IActionResult AddWorkflow(string id, [FromBody] MWorkFlow request)
        {
            var result = svc.AddWorkflow(id, request);
            return Ok(result);
        }

    }
}
