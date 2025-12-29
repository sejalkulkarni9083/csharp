
using UserloginAPI.Models;
using UserloginAPI.services;

namespace UserloginAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class userController : ControllerBase
    {
        private readonly IUserService _UserService;

        public userController(IUserService UserService)
        {
            _UserService = UserService;
        }

        // POST: api/user/register
        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterRequest request)
        {
            var user = _UserService.Register(request);

            if (user == null)
                return BadRequest(new { Message = "User already exists" });

            return Ok(user);
        }

        // POST: api/user/login
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            var user = _UserService.Login(request);

            if (user == null)
                return Unauthorized(new { Message = "Invalid username or password" });

            return Ok(user);
        }
    }
}