using System.ComponentModel.DataAnnotations;

namespace _03.ModelBinding.Models
{
    public class User
    {
        public int Id { get; set; }
        [Display(Name ="Kullanıcı Adı")]
        public string Username { get; set; }
        [Display(Name="Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User()
        {

        }
        public User(int id, string username, string password, string firstName, string lastName)
        {
            Id = id;
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
