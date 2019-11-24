﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Boeing boeing = new Boeing();
                TU134 u134 = new TU134();
                Cargo_Airplane cargo = new Cargo_Airplane();
                Airline airline = new Airline();
                airline.Add(boeing);
                airline.Add(u134);
                airline.Add(cargo);
                airline.Sort();
                airline.ToString();
                int wing;
                string _wing = Console.ReadLine();
                Controller controller = new Controller();
                if (Int32.TryParse(_wing, out wing))
                {
                    Console.WriteLine(controller.Find(wing, airline.transports));
                }
                else
                {
                    throw new DataEcxeption();
                }            
                airline.transports.Remove(u134);
            }
            catch(PassengerPlaneException e)
            {
                Console.WriteLine("Получено исключение при вводе количества пассажиров");
            }
            catch(AviatoinException a)
            {
                Console.WriteLine("Получено исключение при вводе размаха крыла");
            }
            catch(DataEcxeption e)
            {
                Console.WriteLine("Получено исключение при вводе данных");
            }
            finally
            {
                Console.WriteLine("Блок finally");
                Console.ReadLine();
            }
        }
    }
}
