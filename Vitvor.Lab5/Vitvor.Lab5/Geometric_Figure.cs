using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.Lab5
{
    class Geometric_Figure
    {
        class _color
        {
            int _red;
            public int Red
            {
                get
                {
                    return _red;
                }
                set
                {
                    _red = value;
                }
            }
            int _green;
            public int Green
            {
                get
                {
                    return _green;
                }
                set
                {
                    _green = value;
                }
            }
            int _blue;
            public int Blue
            {
                get
                {
                    return _blue;
                }
                set
                {
                    _blue = value;
                }
            }
            public _color()
            {
                Red = Convert.ToInt32(Console.ReadLine());
                Green = Convert.ToInt32(Console.ReadLine());
                Blue = Convert.ToInt32(Console.ReadLine()); 
            }
        }
        public Geometric_Figure()
        {
            Console.WriteLine("Введите цвет в формате RGB");
            _color color = new _color();
        }
    }
}
