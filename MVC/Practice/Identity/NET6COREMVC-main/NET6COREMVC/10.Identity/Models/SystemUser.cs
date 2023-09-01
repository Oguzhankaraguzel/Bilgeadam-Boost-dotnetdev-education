using Microsoft.AspNetCore.Identity;

namespace _10.Identity.Models
{
    public class SystemUser:IdentityUser
    {
        public string Isim { get; set; }
    }
}
