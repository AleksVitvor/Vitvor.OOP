using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP5
{
    public interface ICreate
    {
        void Create();
    }
    [Serializable]
    partial class Transport : CCreate, ICreate
    {
        void ICreate.Create()
        {
            Console.WriteLine("Введите соответствующую цифру для выбора");
            Console.WriteLine("1 - создать самолёт ТУ134");
            Console.WriteLine("2 - создать самолёт Боинг");
            Console.WriteLine("3 - создать грузовой самолёт");
            Console.WriteLine("4 - создать военный самолёт");
            Console.WriteLine("5 - создать пассажирский самолёт");
            char symbol = Convert.ToChar(Console.ReadLine());
            switch (symbol)
            {
                case '1':
                    {
                        TU134 T134 = new TU134();
                        break;
                    }
                case '2':
                    {
                        Boeing boeing = new Boeing();
                        break;
                    }
                case '3':
                    {
                        Cargo_Airplane cargo = new Cargo_Airplane();
                        break;
                    }
                case '4':
                    {
                        War_Plane war = new War_Plane();
                        break;
                    }
                case '5':
                    {
                        Passenger_Plane passenger = new Passenger_Plane();
                        break;
                    }
            }
        }
        public new void Create()
        {
            Console.WriteLine("Введите соответствующую цифру для выбора");
            Console.WriteLine("1 - создать самолёт ТУ134");
            Console.WriteLine("2 - создать самолёт Боинг");
            Console.WriteLine("3 - создать грузовой самолёт");
            Console.WriteLine("4 - создать военный самолёт");
            Console.WriteLine("5 - создать пассажирский самолёт");
            char symbol = Convert.ToChar(Console.ReadLine());
            switch (symbol)
            {
                case '1':
                    {
                        TU134 T134 = new TU134();
                        break;
                    }
                case '2':
                    {
                        Boeing boeing = new Boeing();
                        break;
                    }
                case '3':
                    {
                        Cargo_Airplane cargo = new Cargo_Airplane();
                        break;
                    }
                case '4':
                    {
                        War_Plane war = new War_Plane();
                        break;
                    }
                case '5':
                    {
                        Passenger_Plane passenger = new Passenger_Plane();
                        break;
                    }
            }
        }
        public override string ToString()
        {
            return $"Тип Транспорт";
        }
    }

}
