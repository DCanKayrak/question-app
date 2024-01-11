using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private IRoleService _roleService;

        public RoleController(
            IRoleService roleService
            )
        {
            _roleService = roleService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            throw new NotImplementedException();
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
