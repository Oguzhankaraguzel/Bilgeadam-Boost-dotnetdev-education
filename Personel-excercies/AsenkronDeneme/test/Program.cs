using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        delegate void Temsilci(int s1, double s2);

        static void Main()
        {
            Temsilci Metot = Topla;  // Temsilci Metot = new Temsilci(Topla);
            Metot(7, 77);
        }

        static void Topla(int sayi1, double sayi2)
        {
            Console.WriteLine("Sayı1: {0} - Sayı2: {1} - Sonuç: {2}", sayi1, sayi2, sayi1 + sayi2);
        }
    }
}
