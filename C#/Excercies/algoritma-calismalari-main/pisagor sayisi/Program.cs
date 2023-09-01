using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisagor_sayisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            for (c = 1; c < 500; c++)
            {
                for (b = 1; b < 400; b++)
                {
                    for (a = 1; a < 300; a++)
                    {
                        if ((a+b+c)==1000&&(a*a)+(b*b)==(c*c))
                        {
                            Console.WriteLine("a = "+a+", b = "+b+", c = "+c+", a*b*c = "+(a*b*c));
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
