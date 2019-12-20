using System;
namespace Vitvor.OOP11
{
    class Date:IComparable<Date>
    {
        public int Day { get; set; }
        public int Mounth { get; set; }
        public int Year { get; set; }
        public Date(int day, int mounth, int year)
        {
            Day = day;
            Mounth = mounth;
            Year = year;
        }
        public Date()
        {
            Day = Convert.ToInt32(Console.ReadLine());
            Mounth = Convert.ToInt32(Console.ReadLine());
            Year = Convert.ToInt32(Console.ReadLine());
        }
        public override string ToString()
        {
            return $"{Day}.{Mounth}.{Year}";
        }

        public int CompareTo(Date other)
        {
            if (this.Year < other.Year)
                return 1;
            else if (this.Year == other.Year && this.Mounth < other.Mounth)
                return 1;
            else if (this.Year == other.Year && this.Mounth == other.Mounth && this.Day < other.Day)
                return 1;
            else if (this.Year == other.Year && this.Mounth == other.Mounth && this.Day == other.Day)
                return -1;
            else
                return 0;
        }
    }
}
