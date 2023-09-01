using kahveci_otomasyonu.ENUMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace kahveci_otomasyonu.CLASS
{
    public class Worker : Person
    {
        /*
         * Çalışanlar oluşturulur.
         * Bir listeye eklenir
         */
        #region Worker
        public  bool _Prepare { get; set; }
        public  string _Department { get; set; }

        static Worker _worker = new Worker();

        public Worker()
        {
           
        }


        #endregion

        /// <summary>
        /// çalışana sipariş verilir
        /// </summary>
        /// <param name="worker"></param>
        /// <param name="time"></param>
        /// <param name="order"></param>
        public void SetPrepare(Worker worker, int time ,string order) 
        {
            worker._Prepare = true;
            System.Threading.Thread.Sleep( time );
            Console.WriteLine("Hazır" + order);
            worker._Prepare = false;
        }
        
        /// <summary>
        /// Kullanıcıdan bilgileri alır ve eğer uygun çalışan varsa siparişi iletir.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="order"></param>
        public void GetCashierforOrder(int time, string order, List<Worker> workers) 
        {
            Console.WriteLine("Lütfen Bekleyiniz..");
            while (_worker == null)
            {
                Console.Write(".");
                foreach (Worker worker in workers)
                {
                    if (!worker._Prepare)
                    {
                        _worker = worker;
                        break;
                    }
                    else
                    {
                        _worker = null;
                    }
                }
                Console.Write("\b");

                
            }
            SetPrepare(_worker, time, order);

        }

       


        
    }
}
