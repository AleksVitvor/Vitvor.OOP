using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.Lab5
{
    class Rectangle:Geometric_Figure
    {
        private int Height;
        public int _Height
        {
            get
            {
                return Height;
            }
            set
            {
                if (value > 0)
                    Height = value;
                else
                {
                    Console.WriteLine("Указана неверная высота, установлена высота равныая 1");
                    Height = 1;
                }
            }
        }
        private int Width;
        public int _Width
        {
            get
            {
                return Width;
            }
            set
            {
                if (value > 0)
                    Width = value;
                else
                {
                    Console.WriteLine("Указана неверная ширина, установлена ширина равныая 1");
                    Width = 1;
                }
            }
        }
        public Rectangle()
        {
            Console.WriteLine("Введите высоту и ширину прямоугольника");
            _Height = Convert.ToInt32(Console.ReadLine());
            _Width = Convert.ToInt32(Console.ReadLine());
        }
    }
}
