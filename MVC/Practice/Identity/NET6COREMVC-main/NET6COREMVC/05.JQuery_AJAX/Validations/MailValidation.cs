using System.ComponentModel.DataAnnotations;

namespace _05.JQuery_AJAX.Validations
{
	public class MailValidation : ValidationAttribute
	{
		public override bool IsValid(object? value)
		{
			string kontroledilecekVeri;

			if (value == null)
				return false;

			kontroledilecekVeri = value.ToString();

			if (kontroledilecekVeri.Where(k => k == ' ').ToList().Count() > 0)
				return false;


			if (kontroledilecekVeri.Split("@").Count() > 2)
				return false;



			if (kontroledilecekVeri.EndsWith("@bilgeadam.com"))
				return true;

			return false;


		}
	}
}
