using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.Lab03
{
    class Vitvor_Date
    {
        private int Day = -1;
        public int day
        {
            get
            {
                return Day;
            }
            set
            {
                if (value > 0 || value < 32)
                {
                    Day = value;
                }
                else
                {
                    Console.WriteLine("Превышено допустимое значение номера дня, установлен номер дня = 31");
                    Month = 31;
                }
            }
        }
        private int Year;
        private int Month = -1;
        public int month
        {
            get
            {
                return Month;
            }
            set
            {
                if (value > 1 || value < 12)
                {
                    Month = value;
                }
                else
                {
                    Console.WriteLine("Превышено допустимое значение номера месяца, установлен номер месяца = 12");
                    Month = 12;
                }
            }
        }
        public Vitvor_Date(int da, int mont, int year)
        {
            day = da;
            month = mont;
            Year = year;
        }
        public Vitvor_Date(int da, int year)
        {
            day = da;
            Console.WriteLine("Пожалуйста, введите месяц");
            month = Convert.ToInt32(Console.ReadLine());
            Year = year;
        }
        public Vitvor_Date(int da=1)
        {
            day = da;
            Console.WriteLine("Пожалуйста, введите месяц и год");
            month = Convert.ToInt32(Console.ReadLine());
            Year = Convert.ToInt32(Console.ReadLine());
        }
        
    }
}
