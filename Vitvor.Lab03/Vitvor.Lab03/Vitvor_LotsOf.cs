using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.Lab03
{
    partial class Vitvor_Date
    {
        static private int _numbers;
        readonly int _ID;
        private int _day = -1;
        public int day
        {
            get
            {
                return _day;
            }
            set
            {
                if (value > 0 || value < 32)
                {
                    _day = value;
                }
                else
                {
                    Console.WriteLine("Превышено допустимое значение номера дня, установлен номер дня = 31");
                    _day = 31;
                }
            }
        }
        private int _year;
       
        private int _month = -1;
        public int month
        {
            get
            {
                return _month;
            }
            private set
            {
                if (value > 0 && value < 13)
                {
                    _month = value;
                }
                else
                {
                    Console.WriteLine("Превышено допустимое значение номера месяца, установлен номер месяца = 12");
                    _month = 12;
                }
            }
        }
        public Vitvor_Date(int Day, int Month, int Year)
        {
            _numbers++;
            var datetime = new Random();
            day = Day;
            month = Month;
            _year = Year;
            _ID = (int)(_day * Math.E + _month * Math.PI + _year * datetime.Next(10,99));
        }
        public Vitvor_Date(int Day, int year = 2019)
        {
            _numbers++;
            var datetime = new Random();
            day = Day;
            Console.WriteLine("Пожалуйста, введите месяц");
            month = Convert.ToInt32(Console.ReadLine());
            _year = year;
            _ID = (int)(_day * Math.E + _month * Math.PI + _year * datetime.Next(0, 100));
        }
        public Vitvor_Date()
        {
            _numbers++;
            var datetime = new Random();
            Console.WriteLine("Пожалуйста, введите день");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите месяц");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите год");
            _year = Convert.ToInt32(Console.ReadLine());
            _ID = (int)(_day * Math.E + _month * Math.PI + _year * datetime.Next(0, 100));
        }
        static Vitvor_Date()
        {
            Console.WriteLine("Вы создали объект дата");
        }
        
        ~Vitvor_Date()
        {
            Console.Beep();
        }
        public void SomeDayLater(ref int NumbersOfDays)
        {
            _day = _day + NumbersOfDays;
            if(_day>31)
            {
                _month++;
                _day = _day - 31;
            }
        }
        static public string InfoAboutClass()
        {
            return $"Class name is Vitvor_Date, numbers of objects are {_numbers}";
        }
        public bool Search(int Year)
        {
            if (_year == Year)
                return true;
            else
                return false;
        }
        public bool SearchByDay(int Day)
        {
            if (_day == Day)
                return true;
            else
                return false;
        }
    }
}
