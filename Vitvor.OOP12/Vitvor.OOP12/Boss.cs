using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP12
{
    class Boss
    {
        public delegate void Penalty(double num);
        public event Penalty BadWork;
        public delegate void Increase(int num);
        public event Increase GoodWr;
        public void WorkNotDone()
        {
            Console.WriteLine("Штраф рабочим - 10%");
            BadWork(0.1);
        }
        public void GoodWork()
        {
            Console.WriteLine("Прибавка составит 50 всем рабочим");
            GoodWr(50);
        }
    }
}
