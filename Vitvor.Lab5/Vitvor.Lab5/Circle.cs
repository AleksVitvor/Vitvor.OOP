using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.Lab5
{
    class Circle:Geometric_Figure
    {
        private int Radius;
        public int _Radius
        {
            get
            {
                return Radius;
            }
            set
            {
                if (value > 0)
                    Radius = value;
                else
                {
                    Console.WriteLine("Указан неверный радиус, установлен радиус равный 1");
                    Radius = 1;
                }
            }
        }
        public Circle()
        {
            Console.WriteLine("Введите радиус");
            _Radius = Convert.ToInt32(Console.ReadLine());
        }
    }
}
