using System.ComponentModel.DataAnnotations;

namespace _05.JQUERY_AJAX_VALIDATIONS.Models
{
    public class Personel
    {
        [MinLength(5)]
		public string Name { get; set; }
        [MinLength(5)]
		public string Surname { get; set; }
        [RegularExpression("[0-9]{4}", ErrorMessage ="Sadece 4 hane olacak!")]
		public int Number { get; set; }
        [MinLength(5)]
		public string Section { get; set; }
	}
}
