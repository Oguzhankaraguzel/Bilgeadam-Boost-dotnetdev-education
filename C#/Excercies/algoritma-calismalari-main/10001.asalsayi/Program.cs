using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10001.asalsayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double i = 1, k, c = 0;
                int sayac = 0, siraNo = 0;
                Console.WriteLine("Lutfen sira numarasini giriniz");
                siraNo = int.Parse(Console.ReadLine());
                while (sayac < siraNo)
                {
                    i++;
                    for (k = 1; k <= i; k++)
                    {
                        if (i % k == 0)
                        {
                            c++;
                        }
                    }
                    if (c == 2)
                    {
                        sayac++;
                    }
                    c = 0;
                }
                Console.WriteLine(siraNo + ". Asal sayi = " + i);
            }
        }



    }
}

