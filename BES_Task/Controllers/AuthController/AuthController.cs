using BES_Task.DTO.LoginDtos;
using BES_Task.Services.AuthService;
using Microsoft.AspNetCore.Mvc;

namespace BES_Task.Controllers.AuthController
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : BaseController
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDto loginDto)
        {
            var token = _authService.Authenticate(loginDto.Username, loginDto.Password);

            if (token == null)
            {
                return Unauthorized("Invalid");
            }

            return Ok(new { token });
        }
    }
}
