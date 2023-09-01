using KitapYazarApi.DTO;
using KitapYazarApi.Model;
using KitapYazarApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using TokenHandler = KitapYazarApi.Security.TokenHandler;

namespace KitapYazarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly Context _context;
        private readonly IConfiguration _configuration;
        private readonly SignInManager<User> _signInManager;
        private readonly IUserService _userService;

        public LoginController(Context context, IConfiguration configuration, IUserService userService)
        {
            _context = context;
            _configuration = configuration;
            _userService = userService;
        }
        [HttpGet("myname")]
        [Authorize]
        public IActionResult GetMyName()
        {
            var userName = _userService.GetMyName();
            return Ok(userName);
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(UserDTO userDTO)
        {
            var selectedUser = _context.Users.Where(x => x.UserName == userDTO.UserName && x.Password == userDTO.Password).FirstOrDefault();
            if (selectedUser != null)
            {
                Token token = new Token();
                token.Expiration = DateTime.UtcNow.AddMinutes(50);
                var jwtToken = TokenHandler.GetToken(_configuration, selectedUser, token);
                token.AccessToken = new JwtSecurityTokenHandler().WriteToken(jwtToken);

                return Ok(new { token = token.AccessToken, expires = jwtToken.ValidTo });
            }
            else
            {
                return Unauthorized();
            }
        }

    }
}
