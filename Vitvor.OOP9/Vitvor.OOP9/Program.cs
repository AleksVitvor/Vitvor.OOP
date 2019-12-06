using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP9
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker(500);
            Worker worker1 = new Worker(600);
            Worker worker2 = new Worker(550);
            Worker worker3 = new Worker(900);
            Worker worker4 = new Worker(750);
            Boss boss = new Boss();
            boss.BadWork += worker.OurBadWork;
            boss.BadWork += worker1.OurBadWork;
            boss.BadWork += worker3.OurBadWork;
            boss.GoodWr += worker3.OurGoodWork;
            boss.GoodWr += worker2.OurGoodWork;
            boss.WorkNotDone();
            boss.GoodWork();
            Action<string> test1;
            test1 = (string n) =>
              {
                  int d;
                  if (n.Contains('.'))
                  {
                      d = n.IndexOf('.');
                      n = n.Remove(d, 1);
                  }
                  if (n.Contains(','))
                  {
                      d = n.IndexOf(',');
                      n = n.Remove(d, 1);
                  }
                  Console.WriteLine(n);
              };
            boss.StrUdZnak("Пожалуйста, удалите точки.", test1);
            Func<string, string> test2;
            test2 = (string m) =>
              {
                  m = m.ToUpper();
                  Console.WriteLine(m);
                  return m;
              };
            boss.StrZaglav("не делай его заглавным", test2);
            Action<string, int, string> test3;
            test3 = (string stroka, int poz, string simv) => {
                stroka = stroka.Insert(poz, simv);
                Console.WriteLine(stroka);
            };
            Action<string, int> test4;
            test4 = (string stroka, int poz) => {
                stroka = stroka.Insert(poz, " ");
                Console.WriteLine(stroka);
            };
            Action<string, char> test5;
            test5 = (string stroka, char simv) => {
                int b;
                if (stroka.Contains(simv))
                {
                    b = stroka.IndexOf(simv);
                    stroka = stroka.Remove(b, 1);
                }
                Console.WriteLine(stroka);
            };
            Console.ReadLine();
        }
        
    }
}
