using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP5
{
    class Airline
    {
        public List<Aviation> transports = new List<Aviation>();
        public void Add(Aviation obj)
        {
            transports.Add(obj);
        }
        public override string ToString()
        {
            int NumberOfPeople = 0;
            int Capacity = 0;
            for(short i=0;i<transports.Count;i++)
            {
                if(transports[i] is Cargo_Airplane)
                {
                    Capacity = Capacity + ((Cargo_Airplane)transports[i])._Carrying_Capacity;
                    continue;
                }
                if(transports[i] is Passenger_Plane)
                {
                    NumberOfPeople = NumberOfPeople + ((Passenger_Plane)transports[i])._NumberOfPassangers;
                }
            }
            return $"Общее количество самолётов {transports.Count} с грузоподъёмностью {Capacity} и пассажировместимостью {NumberOfPeople}";
        }
        public void Sort()
        {
            transports.Sort();
        }
    }
}
