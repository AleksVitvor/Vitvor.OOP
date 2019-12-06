using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP5
{
    [Serializable]
    class Boeing: Passenger_Plane
    {
        public string Model { get; set; }

        public Boeing()
        {
            Console.WriteLine("Введите модель самолёта");
            Model = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"Тип пассжирский самолёт Boeing модели {Model}";
        }
    }
}
