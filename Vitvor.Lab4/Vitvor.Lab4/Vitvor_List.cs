using System;

namespace Vitvor.Lab4
{
    class Vitvor_List
    {
        private class Date
        {
            int _Day { get; set; }
            int _Month { get; set; }
            public Date(int Day, int Month)
            {
                _Day = Day;
                _Month = Month;
            }

        }
        private int _numbers;
        public int Numbers
        {
            get
            {
                return _numbers;
            }
            set
            {
                if (value > 0)
                    _numbers = value;
                else
                    _numbers = 1;
            }
        }

        ObjectInList[] _Lists;
        private Owner owner = new Owner("Alex", "BelSTU");
        public Vitvor_List(int numbers)
        {
            Console.WriteLine("Please, enter date");
            int day = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            Date date = new Date(day, month);
            Numbers = numbers;
            _Lists = new ObjectInList[numbers];
        }
        public void Create(int numbers)
        {
            for(int i=0;i<numbers;i++)
            {
                this[i] = new ObjectInList();
            }
        }
        public ObjectInList this[int index]
        {
            get
            {
                return _Lists[index];
            }
            set
            {
                _Lists[index] = value;
            }
        }
        public static int operator -(Vitvor_List Obj1, Vitvor_List Obj2)
        {
            return Obj1._numbers - Obj2._numbers;
        }
        public static bool operator >(Vitvor_List Obj1, ObjectInList Obj2)
        {
            for (int i = 0; i < Obj1._numbers; i++)
            {
                if (Obj1[i].NumbersOfPlayers == Obj2.NumbersOfPlayers && Obj1[i].nameofcoach == Obj2.nameofcoach && Obj1[i].nameofteam == Obj2.nameofteam)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator <(Vitvor_List Obj1, ObjectInList Obj2)
        {
            for (int i = 0; i < Obj1._numbers; i++)
            {
                if (Obj1[i].NumbersOfPlayers == Obj2.NumbersOfPlayers && Obj1[i].nameofcoach == Obj2.nameofcoach && Obj1[i].nameofteam == Obj2.nameofteam)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Vitvor_List list1, Vitvor_List list2)
        {
            return (list1._numbers != list2._numbers) ? true : false;
        }
        public static bool operator ==(Vitvor_List list1, Vitvor_List list2)
        {
            return (list1._numbers == list2._numbers) ? true : false;
        }
        public static Vitvor_List operator +(Vitvor_List list1, Vitvor_List list2)
        {
            int i = 0;
            Vitvor_List NewList = new Vitvor_List(list1._numbers + list2._numbers);
            for (int j = 0; j < list1._numbers; i++, j++) 
            {
                NewList[i] = new ObjectInList(list1._Lists[j].nameofteam, list1._Lists[j].nameofcoach, list1._Lists[j].NumbersOfPlayers);
            }
            for (int j = 0; j < list2._numbers; i++, j++)
            {
                NewList[i] = new ObjectInList(list2._Lists[j].nameofteam, list2._Lists[j].nameofcoach, list2._Lists[j].NumbersOfPlayers);
            }
            return NewList;
        }
        public override string ToString()
        {
            return ($"List consist of {_numbers} and creator is {owner._Name} from {owner._Organization} with ID {owner._ID}");
        }
    }
}