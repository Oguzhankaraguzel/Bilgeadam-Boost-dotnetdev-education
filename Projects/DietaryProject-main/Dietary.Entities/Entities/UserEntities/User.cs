using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietary.Entities.Entities.UserEntities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public UserDetail UserDetail { get; set; }

    }
}
