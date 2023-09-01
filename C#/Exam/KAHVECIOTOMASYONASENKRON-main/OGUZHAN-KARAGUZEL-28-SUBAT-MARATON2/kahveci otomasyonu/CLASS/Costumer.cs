using kahveci_otomasyonu.ENUMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kahveci_otomasyonu.CLASS
{
    public class Costumer : Person
    {
        public string Order { get; set; } = "";

        
        public int OrderPrepareTime { get; set; } = 0;
        public Costumer()
        {
            uint i = 0;
            Console.WriteLine("Siparişiniz");

            GetTheMenu();
            i = Convert.ToUInt32(Console.ReadLine());
            switch (i) 
            {
                case 1:
                    OrderPrepareTime += (int)Coffee.turkhisCoffee;
                    Order = Coffee.turkhisCoffee.ToString();
                    break;
                case 2:
                    OrderPrepareTime += (int)Coffee.CafeLatte;
                    Order = Coffee.CafeLatte.ToString();
                    break;
                case 3:
                    OrderPrepareTime += (int)Coffee.Americano;
                    Order = Coffee.Americano.ToString();
                    break;
                case 4:
                    OrderPrepareTime += (int)Coffee.Mocha;
                    Order = Coffee.Mocha.ToString();
                    break;
                default:
                    Console.WriteLine("HATALI GİRİŞ!");
                    break;
            }
            Console.WriteLine("EKSTRA MALZEME");

            GetTheEkstras();
            i = Convert.ToUInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    OrderPrepareTime += (int)ekstras.Sugar;
                    Order += " " + ekstras.Sugar.ToString();
                    break;
                case 2:
                    OrderPrepareTime += (int)ekstras.Syruo;
                    Order += " " + ekstras.Syruo.ToString();
                    break;
                case 3:
                    OrderPrepareTime += (int)ekstras.souce;
                    Order += " " + ekstras.souce.ToString();
                    break;
                case 4:
                    OrderPrepareTime += (int)ekstras.Chocolatesouce;
                    Order += " " + ekstras.Chocolatesouce.ToString();
                    break;
                default:
                    Console.WriteLine("HATALI GİRİŞ!");
                    break;
            }

        }


        private void GetTheMenu() 
        {
            Console.WriteLine($"{Coffee.turkhisCoffee} = 1\n{Coffee.CafeLatte} = 2\n{Coffee.Americano} = 3\n{Coffee.Mocha} = 4 ");
        }

        private void GetTheEkstras()
        {
            Console.WriteLine($"{ekstras.Sugar} = 1\n{ekstras.Syruo} = 2\n{ekstras.souce} = 3\n{ekstras.Chocolatesouce} = 4 ");
        }


    }
}
