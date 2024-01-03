using AutoMapper;
using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using Entities.Concrete.Dto.Request.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost("Register")]
        public IActionResult Register(RegisterRequestDto req)
        {
            var userExist = _authService.UserExists(req.Email);

            if (!userExist.Success)
            {
                return BadRequest(userExist.Message);
            }
            var registerUser = _authService.Register(req, req.Password);
            var result = _authService.CreateAccessToken(registerUser.Data);
            if (!registerUser.Success)
            {
                return BadRequest(registerUser.Message);
            }
            return Ok(result.Data);

        }
        [HttpPost("Login")]
        public IActionResult Login(LoginRequestDto req)
        {
            var userToLogin = _authService.Login(req);
            var result = _authService.CreateAccessToken(userToLogin.Data);
            if (!userToLogin.Success)
            {
                return BadRequest(userToLogin.Message);
            }
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);

        }
    }
}
