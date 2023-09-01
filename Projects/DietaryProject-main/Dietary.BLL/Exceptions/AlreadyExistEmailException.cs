using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietary.BLL.Exceptions
{
    public class AlreadyExistEmailException : Exception
    {
        public AlreadyExistEmailException() : base("There is a user with this email")
        {

        }
        public AlreadyExistEmailException(string msg) : base(msg)
        {

        }
    }
}