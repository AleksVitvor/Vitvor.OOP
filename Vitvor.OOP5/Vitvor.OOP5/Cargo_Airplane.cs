using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP5
{
    class Cargo_Airplane: Aviation
    {
        private int Carrying_Capacity;
        public int _Carrying_Capacity
        {
            get
            {
                return Carrying_Capacity;
            }
            set
            {
                if(value>0)
                {
                    Carrying_Capacity = value;
                }
                else
                {
                    Console.WriteLine("Установлена грузоподъёмность 200 тонн");
                    Carrying_Capacity = 200;
                }
            }
        }
        public Cargo_Airplane()
        {
            Console.WriteLine("Введите грузоподъёмность самолёта");
            int carrying_capacity = Convert.ToInt32(Console.ReadLine());
        }
    }
}
