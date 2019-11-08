using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP5
{
    class TU134: Passenger_Plane
    {
        public string CountryOfOrigin { get; set; }
        public TU134()
        {
            Console.WriteLine("Введите страну производстав самолёта");
            CountryOfOrigin = Console.ReadLine();
        }
    }
}
