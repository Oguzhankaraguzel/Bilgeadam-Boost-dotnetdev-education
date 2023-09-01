using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_20_hepsinebolunebilen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double arananSayi = 21;
            int sayac = 0;
            while (true)
            {
                for (double i = 1; i < 21; i++)
                {
                    if (arananSayi % i == 0)
                    {
                        sayac++;
                    }
                }
                if (sayac == 20)
                {
                    break;
                }
                sayac = 0;
                arananSayi++;
            }
            Console.WriteLine("[1-20] arasi sayilara bolunebilen sayi = "+arananSayi);
            Console.ReadLine();
        }
    }
}
