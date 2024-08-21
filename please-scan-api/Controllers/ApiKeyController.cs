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
    public class ApiKeyController : ControllerBase
    {
        private readonly IApiKeyService svc;

        [ExcludeFromCodeCoverage]
        public ApiKeyController(IApiKeyService service)
        {
            svc = service;
        }

        [ExcludeFromCodeCoverage]
        [HttpGet]
        //Check if API Key found & not expire in the specific organization
        [Route("org/{id}/action/VerifyApiKey/{apiKey}")]
        public IActionResult VerifyApiKey(string id, string apiKey)
        {
            var result = svc.VerifyApiKey(id, apiKey);
            return Ok(result);
        }

        [ExcludeFromCodeCoverage]
        [HttpPost]
        [Route("org/{id}/action/AddApiKey")]
        public IActionResult AddApiKey(string id, [FromBody] MApiKey request)
        {
            var result = svc.AddApiKey(id, request);
            return Ok(result);
        }

        [ExcludeFromCodeCoverage]
        [HttpDelete]
        [Route("org/{id}/action/DeleteApiKeyById/{keyId}")]
        public IActionResult DeleteApiKeyById(string id, string keyId)
        {
            var result = svc.DeleteApiKeyById(id, keyId);
            return Ok(result);
        }

        [ExcludeFromCodeCoverage]
        // Use POST method, in the future we might send the body
        [HttpPost]
        [Route("org/{id}/action/GetApiKeys")]
        public IActionResult GetApiKeys(string id)
        {
            var result = svc.GetApiKeys(id);
            return Ok(result);
        }
    }
}
