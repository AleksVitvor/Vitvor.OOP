using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP5
{
    class Passenger_Plane: Aviation
    {
        private int NumberOfPassangers;
        public int _NumberOfPassangers
        {
            get
            {
                return NumberOfPassangers;
            }
            set
            {
                if (value > 0)
                {
                    NumberOfPassangers = value;
                }
                else
                {
                    Console.WriteLine("Установлена количество человек 200");
                    NumberOfPassangers = 200;
                }
            }
        }
        public Passenger_Plane()
        {
            Console.WriteLine("Введите количество пассажиров самолёта");
            int carrying_capacity = Convert.ToInt32(Console.ReadLine());
        }
    }
}
