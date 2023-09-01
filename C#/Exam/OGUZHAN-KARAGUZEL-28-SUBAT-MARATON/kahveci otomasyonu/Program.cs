using kahveci_otomasyonu.CLASS;
using kahveci_otomasyonu.ENUMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kahveci_otomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker _worker1 = new Worker();
            Worker _worker2 = new Worker();
            Worker _worker3 = new Worker();
            Worker _worker4 = new Worker();

            List<Worker> _workers = new List<Worker>();

            _worker1.Name = "JOE";
            _worker1.Status = PersonStatus.Worker.ToString();
            _worker1._Department = Department.Cashier.ToString();

            _worker2.Name = "JACK";
            _worker2.Status = PersonStatus.Worker.ToString();
            _worker2._Department = Department.Production.ToString();

            _worker3.Name = "WILLIAM";
            _worker3.Status = PersonStatus.Worker.ToString();
            _worker3._Department = Department.Production.ToString();

            _worker4.Name = "AVAREL";
            _worker4.Status = PersonStatus.Worker.ToString();
            _worker4._Department = Department.Production.ToString();

            _workers.Add(_worker2);
            _workers.Add(_worker3);
            _workers.Add(_worker4);

            Queue<Costumer> queue = new Queue<Costumer>();

            while (true)
            {
                Costumer costumer = new Costumer();
                queue.Enqueue(costumer);
                _worker1.GetCashierforOrder(queue.Peek().OrderPrepareTime, queue.Peek().Order, _workers);
                queue.Dequeue();
            }
        }
    }
}
