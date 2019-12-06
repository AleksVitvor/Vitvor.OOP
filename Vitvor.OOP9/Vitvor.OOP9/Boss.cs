using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP9
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
        public void StrUdZnak(string a, Action<string> test1) => test1(a);
        public void StrDobSimv(string a, int pozit, string j, Action<string, int, string> test3) => test3(a, pozit, j);
        public void StrDobProb(string a, int pozition, Action<string, int> test4) => test4(a, pozition);
        public void StrUdSimv(string a, char x, Action<string, char> test5) => test5(a, x);
        public string StrZaglav(string a, Func<string, string> test2)
        {
            return test2(a);
        }
    }
}
