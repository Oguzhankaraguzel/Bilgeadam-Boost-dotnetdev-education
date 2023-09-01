using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietary.BLL.Exceptions
{
    public class InvalidMealException : Exception
    {
        public InvalidMealException() : base("Specified meal not found.") { }

        public InvalidMealException(string msg) : base(msg) { }
        
    }
}
