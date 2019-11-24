using System;

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
                    throw new PassengerPlaneException();
                }
            }
        }
        public Passenger_Plane()
        {
            Console.WriteLine("Введите количество пассажиров самолёта");
            string _NumberOfPassengers_ = Console.ReadLine();
            int _number;
            if (!(Int32.TryParse(_NumberOfPassengers_, out _number)))
            {
                throw new PassengerPlaneException();
            }
            else
            {
                _NumberOfPassangers = _number;
            }
        }
        public override string ToString()
        {
            return $"Тип пассжирский самолёт";
        }
    }
}
