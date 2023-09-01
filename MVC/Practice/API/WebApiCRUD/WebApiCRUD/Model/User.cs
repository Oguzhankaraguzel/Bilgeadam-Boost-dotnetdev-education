using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WebApiCRUD.Model
{
    public class User
    {
        [BindNever]
        public int Id { get; set; }
        public string  UserName { get; set; }
        public string Password { get; set; }
    }
}
