using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using Entities.Concrete.Dto.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.utils.constants;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IQuestionService _questionService;
        private AuthController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        [HttpGet(Apis.Auth.LOGIN)]
        public IActionResult Login([FromBody] RegisterRequestDto request)
        {
            return Ok();
        } 
    }
}
