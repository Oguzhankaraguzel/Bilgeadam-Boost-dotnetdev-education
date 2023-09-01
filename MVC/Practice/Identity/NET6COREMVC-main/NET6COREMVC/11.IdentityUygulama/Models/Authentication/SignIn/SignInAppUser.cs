using System.ComponentModel.DataAnnotations;

namespace AUTHENTICATION.Models.Authentication.SignIn
{
	public class SignInAppUser
	{
		[Required(ErrorMessage = "Bu bilginin girilmesi zorunludur.")]
		public string? Username { get; set; }
		//[MinLength(8)]
		[Required(ErrorMessage = "Bu bilginin girilmesi zorunludur.")]
		[DataType(DataType.Password)]
		public string? Password { get; set; }
	}
}
