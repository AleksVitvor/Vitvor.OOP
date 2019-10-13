using System;
using System.Collections.Generic;

namespace Vitvor.Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Vitvor_Date Date = new Vitvor_Date(12);
            Console.WriteLine(Date.ToString());
            int x = Convert.ToInt32(Console.ReadLine());
            Date.SomeDayLater(ref x);
            Console.WriteLine(Date.ToString());
            Vitvor_Date Date1 = new Vitvor_Date(12, 12, 2019);
            Console.WriteLine(Date1.ToString());
            Console.WriteLine(Date1.Equals(Date));
            Console.WriteLine(Date1.GetHashCode());
            Console.WriteLine(Vitvor_Date.InfoAboutClass());
            Console.WriteLine(Date.GetType());
            List<Vitvor_Date> Dates = new List<Vitvor_Date>();
            int numbers = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numbers; i++) 
            {
                Vitvor_Date _Date = new Vitvor_Date();
                Dates.Add(_Date);
                Console.WriteLine(_Date.ToString());
            }
            Console.WriteLine("Введите год для поиска");
            int _year = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numbers; i++) 
            {
                if (Dates[i].Search(_year))
                    Console.WriteLine(Dates[i].ToString());
            }
            Console.WriteLine("Введите день для поиска");
            int _day = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numbers; i++)
            {
                if (Dates[i].SearchByDay(_day))
                    Console.WriteLine(Dates[i].ToString());
            }
            Console.ReadLine();
        }
    }
}
