using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietary.BLL.Exceptions
{
    public class InvalidFoodGramException : Exception
    {
        public InvalidFoodGramException() : base("Please enter a valid food gram")
        {
            
        }

        public InvalidFoodGramException(string msg) : base(msg) 
        {
            
        }
    }
}
