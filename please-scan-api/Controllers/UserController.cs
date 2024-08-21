using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Its.PleaseScan.Api.Models;
using Its.PleaseScan.Api.Services;

namespace Its.PleaseScan.Api.Controllers
{
    [ApiController]
    [Authorize(Policy = "GenericRolePolicy")]
    [Route("/api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService svc;

        [ExcludeFromCodeCoverage]
        public UserController(IUserService service)
        {
            svc = service;
        }

        [ExcludeFromCodeCoverage]
        [HttpGet]
        [Route("org/{id}/action/AdminGetUsers")]
        public IActionResult AdminGetUsers(string id)
        {
            var result = svc.GetUsers(id);
            return Ok(result);
        }

        [ExcludeFromCodeCoverage]
        [HttpPost]
        [Route("org/{id}/action/AdminAddUser")]
        public IActionResult AdminAddUser(string id, [FromBody] MUser request)
        {
            var result = svc.AddUser(id, request);
            return Ok(result);
        }
    }
}
