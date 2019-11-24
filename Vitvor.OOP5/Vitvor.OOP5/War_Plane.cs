using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP5
{
    sealed class War_Plane: Aviation
    {
        public string Appointment { get; set; }
        public War_Plane()
        {
            Console.WriteLine("Введите назначение самолёта");
            Appointment = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"Тип военный самолёт";
        }
    }
}
