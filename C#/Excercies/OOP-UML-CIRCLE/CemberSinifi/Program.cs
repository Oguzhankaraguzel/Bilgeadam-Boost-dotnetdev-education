using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CemberSinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cember cember1 = new Cember(2, 0, 2);
            Cember cember2 = new Cember(3.1, 0, 1);
            cember1.Yaz();
            cember2.Yaz();
            Console.WriteLine(cember1.İcindeMi(cember2));
            Console.WriteLine(cember2.İcindeMi(cember1));
            Console.WriteLine(cember1.Mesafe(cember2));
            Console.WriteLine(cember2.Mesafe(cember1));
            Console.ReadKey();
        }
    }
}
