using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietary.BLL.Exceptions
{
    public class InvalidFoodException : Exception
    {
        public InvalidFoodException() : base("Please Coose a food for adding to meal") 
        {
            
        }

        public InvalidFoodException(string msg) : base(msg)
        {
            
        }
    }
}
