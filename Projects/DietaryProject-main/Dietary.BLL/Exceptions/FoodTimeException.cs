using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietary.BLL.Exceptions
{
    public class FoodTimeException : Exception
    {
        public FoodTimeException() : base("Invalid Food Time")
        {
            
        }
        public FoodTimeException(string msg) : base(msg) 
        {
            
        }
    }
}
