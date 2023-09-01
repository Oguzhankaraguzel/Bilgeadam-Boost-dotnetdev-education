using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietary.BLL.Exceptions
{
    public class UserNameException : Exception
    {
        public UserNameException() : base("This username is already in use") { }
        public UserNameException(string msg) : base(msg) { }
    }
}
