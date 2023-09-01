using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietary.BLL.Exceptions
{
    public class UserEmptyEmailException : Exception
    {
        public UserEmptyEmailException() : base("Please enter a valid e-mail") { }

        public UserEmptyEmailException(string msg) : base(msg) { }

    }
}
