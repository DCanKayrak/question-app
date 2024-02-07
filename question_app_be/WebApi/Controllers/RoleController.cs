using Business.Abstract;
using Core.Extensions;
using Core.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private IRoleService _roleService;
        private IHttpContextAccessor _httpContextAccessor;

        public RoleController(
            IRoleService roleService
            )
        {
            _roleService = roleService;
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();
        }

        [HttpGet]
        public IActionResult GetAllRoles()
        {
            var result = _roleService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpGet("/{role}")]
        public IActionResult isRoleExists(string role)
        { 
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
            if (roleClaims.Contains(role))
            {
                return Ok();
            }

            return BadRequest();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _roleService.Get(id);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }
    }
}
