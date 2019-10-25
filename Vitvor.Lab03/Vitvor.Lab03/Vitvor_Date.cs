using System;

namespace Vitvor.Lab03
{
    partial class Vitvor_Date
    {
        public override string ToString()
        {
            return $"Date {_ID} {_day}.{_month}.{_year}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Vitvor_Date Date = obj as Vitvor_Date;
            if (Date as Vitvor_Date == null)
                return false;
            if(_day==Date._day && _month==Date._month)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            var datetime = new Random();
            return (int)(_day * _month * Math.E * _numbers * Math.PI* datetime.Next(0,99));
        }
    }
}
