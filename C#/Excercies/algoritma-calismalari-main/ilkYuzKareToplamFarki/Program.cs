using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilkYuzKareToplamFarki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kareToplam = 0, toplamKare = 0;
            for (int i = 1; i <= 100; i++)
            {
                kareToplam += i * i;
                toplamKare += i;
            }
            toplamKare *= toplamKare;
            Console.WriteLine("1-100 arasi sayilarin karelerinin toplami = "+kareToplam+"\n\n1-100 arasi sayilarin toplamlarinin karesi = "+toplamKare+"\n\nIkisinin farki = "+(toplamKare-kareToplam));
            Console.ReadKey();
        }
    }
}
