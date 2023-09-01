using _10.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace _10.Identity.Controllers
{
    public class MyAccountController:Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        public MyAccountController(SignInManager<IdentityUser>  signInManager,UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public void AddUser(SystemUser user) 
        {
            //_userManager.AddToRoleAsync(user, "normalUser");  
        }

        public IActionResult Index()
        {
            return View(_userManager.Users.ToList());
        }
    }
}
