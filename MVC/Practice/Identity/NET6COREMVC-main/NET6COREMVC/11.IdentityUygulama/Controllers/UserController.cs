using _11.IdentityUygulama.Models.Authentication.SignUp;
using AppUser.Management.Service.Services;
using AUTHENTICATION.Models;
using AUTHENTICATION.Models.Authentication.SignIn;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MyCompany.Management.Service.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace _11.IdentityUygulama.Controllers
{
    public class UserController : Controller
    {
        //SOLID (S - Single Responsibility - Tek Sorumluluk)
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly IEmailService _emailService;
        public UserController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration, IEmailService emailService)
        {
            //SOLID (D - Dependency Injection (Bağımlılık Enjeksiyonu))
            _userManager = userManager;
            //SOLID (D - Dependency Injection (Bağımlılık Enjeksiyonu))
            _roleManager = roleManager;
            //SOLID (D - Dependency Injection (Bağımlılık Enjeksiyonu))
            _configuration = configuration;
            //SOLID (D - Dependency Injection (Bağımlılık Enjeksiyonu))
            _emailService = emailService;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp([FromForm] SignUpAppUser appUser, string role = "USER")
        {
            IActionResult viewResult = null;
            //Kullanıcını kayıt olabilmesi için benzersiz bir username ve email bilgisi olması gerekir!
            //Username
            //Email

            var userByName = await _userManager.FindByNameAsync(appUser.Username);
            var userByEmail = await _userManager.FindByEmailAsync(appUser.Email);

            if (userByName != null || userByEmail != null)
            {
                viewResult = StatusCode(StatusCodes.Status400BadRequest, new AppResponse() { Status = "HATA OLUŞTU!", Message = "Bu username ya da email adresine sahip kullanıcı sistemde bulunmaktadır!" });
            }
            else
            {
                var userRole = await _roleManager.FindByNameAsync(role);
                if (userRole != null)
                {
                    IdentityUser eklenecekKullanici = new()
                    {
                        UserName = appUser.Username,
                        Email = appUser.Email,
                        SecurityStamp = Guid.NewGuid().ToString()
                    };

                    var eklemeSonucu = await _userManager.CreateAsync(eklenecekKullanici, appUser.Password);

                    if (eklemeSonucu.Succeeded)
                    {
                        await _userManager.AddToRoleAsync(eklenecekKullanici, role);
                        viewResult = RedirectToAction("Index");
                    }
                    else
                    {
                        viewResult = StatusCode(StatusCodes.Status500InternalServerError, new AppResponse() { Status = "HATA OLUŞTU!", Message = "Kullanıcı sisteme kayıt edilirken sunucuda hata oluştu!" });
                    }
                }
                else
                {
                    viewResult = StatusCode(StatusCodes.Status400BadRequest, new AppResponse() { Status = "HATA OLUŞTU!", Message = "Uygulamada böyle bir kullanıcı rolü bulunmamaktadır!" });
                }                
            }

            return viewResult;

        }


        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn([FromForm] SignInAppUser appUser)
        {
            IActionResult viewResult;

            var userByName = await _userManager.FindByNameAsync(appUser.Username);

            if(userByName != null)
            {
                if(await _userManager.CheckPasswordAsync(userByName, appUser.Password))
                {
                    //TOKEN GENERATION
                    //TOKEN DISPLAY

                    /*var payload = new List<Claim>() { new Claim(ClaimTypes.Name,appUser.Username),
                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())};*/

                    var payload = new List<Claim>() { new Claim("username",appUser.Username),
                    new Claim("tokenID",Guid.NewGuid().ToString())};

                    //3 sa 15 dk sonra yok olacak bir JWT üreteceğiz.
                    var jwtToken = GetToken(payload, 3, 15);
                    var tokenStr = new JwtSecurityTokenHandler().WriteToken(jwtToken);


                    //viewResult = RedirectToAction("Index", "Home");
                    viewResult = Ok(new { token=tokenStr, expires=jwtToken.ValidTo});
                }
                else
                {
                    viewResult = StatusCode(StatusCodes.Status406NotAcceptable, new AppResponse() { Status = "PAROLA HATASI!", Message = "Girilen parola hatalıdır!" });
                }
            }
            else
            {
                viewResult = StatusCode(StatusCodes.Status406NotAcceptable, new AppResponse() { Status = "KULLANICI ADI HATASI!", Message = "Sistemde böyle bir kullanıcı adı bulunmamaktadır!" });
            }

            return viewResult;
        }

        private JwtSecurityToken GetToken(List<Claim> payload, int hours, int minutes)
        {
            //Sunucu tarafındaki JWT:Secret
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("JWT")["Secret"]));

            var token = new JwtSecurityToken(
                audience: _configuration["JWT:ValidAudience"],
                issuer: _configuration["JWT:ValidIssuer"],
                //Belirlenen saat ve dakika sonrasında token sonlanacaktır.
                expires: DateTime.UtcNow.AddHours(hours).AddMinutes(minutes),
                //notBefore: DateTime.UtcNow.AddMinutes(5),//5 dk sonra token aktif olacaktır.
                claims: payload,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

            return token;
        }

        public IActionResult SendMail()
        {

            var emailMessage = new MailMessage(new Dictionary<string, string>() { { "Fatih Kaan Açıkgöz 1", "fatihkaanacikgoz@gmail.com" }, { "HİÇBİR ŞEY YAZMADIM", "fatihimin3406@gmail.com" } }, "İlk mail denemesi başlığı", "<h1>Mantığının anlaşılması gereken hadiseler</h1><ol><li>OOP Mantığı</li><li>SOLID prensipleri</li></ol><p>Yazan: <b>Fatih Kaan Açıkgöz</b></p>");

            _emailService.SendEmail(emailMessage);


            return StatusCode(StatusCodes.Status200OK, new AppResponse() { Status = "Başarılı", Message = "Email başarıyla gönderildi!" });
        }
    }
}
