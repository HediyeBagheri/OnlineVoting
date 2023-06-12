using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineVoting.Application.Contract.DTOs.Condidates;
using OnlineVoting.Application.Contract.DTOs.Users;
using OnlineVoting.Application.Contract.IServices.Users;

namespace OnlineVoting.EndPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginDTO dto)
        {
            string token = userService.Login(dto);
            return Ok(token);
        }

        [HttpPost("[action]")]
        public IActionResult Register(RegisterDTO dto)
        {
            userService.Register(dto);
            return Ok();
        }

        
    }
}
