using System.ComponentModel.DataAnnotations;

namespace _05.JQuery_AJAX.Models
{
	public class Personel
	{
		[MinLength(5)]
		public string Name { get; set; }
		[MinLength(5)]
		public string Surname { get; set; }
		[RegularExpression("[0-9]{5}")]
		public int Number { get; set; }
		[MinLength(5)]
		public string Section { get; set; }

	}
}
