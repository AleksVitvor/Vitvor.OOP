using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP5
{
    class Aviation: Transport
    {
        private int Wingspan;
        public int _Wingspan
        {
            get
            {
                return Wingspan;
            }
            set
            {
                if(value>0)
                {
                    Wingspan = value;
                }
                else
                {
                    Wingspan = 10;
                }
            }
        }
        public Aviation()
        {
            Console.WriteLine("Введите размах крыла");
            _Wingspan = Convert.ToInt32(Console.ReadLine());
        }
    }
}
