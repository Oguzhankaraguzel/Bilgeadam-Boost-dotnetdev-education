using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using _05.JQuery_AJAX.Validations;

namespace _05.JQuery_AJAX.Models
{
	public class SystemUser
	{
		[Required(ErrorMessage = "Kullanıcı adı boş olamaz!")]
		[StringLength(10, ErrorMessage = "Kullanıcı adı en az 3 en fazla 10 karakter olmalıdır!", MinimumLength = 3)]
		public string UserName { get; set; }

		[Required(ErrorMessage = "T.C kimlik numarası adı boş olamaz!")]

		[IdentificationNumberValidation(ErrorMessage = "Geçersiz T.C. Numarası")]
		public long IdentificationNumber { get; set; }  //T.C. kimlik numarası

		[Required(ErrorMessage = "Puan boş olamaz!")]
		[Range(0, 100, ErrorMessage = "Puanınız [0,100] arasında olmalıdır!")]
		public int Score { get; set; }

		[Required(ErrorMessage = "Mail adresi boş olamaz!")]
		[MailValidation(ErrorMessage = "E posta adresi @bilgeadam.com ile sonlanmalıdır ve boşluk içermemelidir!")]
		public string EmailAddress { get; set; }

		[Required(ErrorMessage = "Şifre boş olamaz!")]
		[StringLength(20, ErrorMessage = "Şifre en az 8 en fazla 20 karakter olmalıdır!", MinimumLength = 8)]
		public string Password { get; set; }

		[Required(ErrorMessage = "Şifre tekrarı boş olamaz!")]
		[Compare("Password", ErrorMessage = "Parola ve tekrarı aynı olmalıdır!")]
		public string PasswordConfirmation { get; set; }
	}
}
