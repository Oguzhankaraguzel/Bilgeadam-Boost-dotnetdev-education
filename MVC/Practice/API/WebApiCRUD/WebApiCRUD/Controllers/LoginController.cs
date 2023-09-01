using Microsoft.AspNetCore.Mvc;
using WebApiCRUD.Dto;
using WebApiCRUD.Model;
using WebApiCRUD.Security;

namespace WebApiCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly YazarKitapDbContext _context;
        public LoginController(YazarKitapDbContext context)
        {
            _context = context;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromForm] UserLoginDTO userdto)
        {
            var _user = _context.Users.Where(x => x.UserName.Equals(userdto.UserName)).FirstOrDefault();

            if (_user != null)
            {

                if (_user.Password == userdto.Password)
                {
                    Token token = new Token();
                    return Ok();

                }
                else
                {
                    return Unauthorized();
                }
            }
            else
            {
                return Unauthorized();
            }

        }
        //private JwtSecurityToken GetToken(List<Claim> authClaims, int hours, int minutes)
        //{
        //    //Sunucu tarafındaki JWT:Secret
        //    var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
        //    var token = new JwtSecurityToken(
        //    issuer: _configuration["JWT:ValidIssuer"],
        //    audience: _configuration["JWT:ValidAudience"],
        //                   //Belirlenen saat ve dakika sonrasında token sonlanacaktır.
        //                   expires: DateTime.UtcNow.AddHours(hours).AddMinutes(minutes),
        //    notBefore: DateTime.UtcNow.AddMinutes(5),//5 dk sonra token aktif olacaktır.
        //                   claims: authClaims,
        //    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
        //    );
        //    return token;
        //}
    }
}
