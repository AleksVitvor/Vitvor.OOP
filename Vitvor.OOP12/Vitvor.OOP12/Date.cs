using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP12
{
    class Date : IComparable<Date>
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
            Console.WriteLine("Write date");
            Day = Convert.ToInt32(Console.ReadLine());
            Mounth = Convert.ToInt32(Console.ReadLine());
            Year = Convert.ToInt32(Console.ReadLine());
        }
        public override string ToString()
        {
            return $"{Day}.{Mounth}.{Year}";
        }
        public void WriteSth(string write, int i)
        {
            Console.Write(write+i);
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
