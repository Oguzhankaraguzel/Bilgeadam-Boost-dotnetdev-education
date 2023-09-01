using System.ComponentModel.DataAnnotations;

namespace _11.IdentityUygulama.Models.Authentication.SignUp
{
    public class SignUpAppUser
    {
        [Required(ErrorMessage = "Bu bilginin girilmesi zorunludur.")]
        public string? Username { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Bu bilginin girilmesi zorunludur.")]
        public string? Email { get; set; }
        //[MinLength(8)]
        [Required(ErrorMessage = "Bu bilginin girilmesi zorunludur.")]
        
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
