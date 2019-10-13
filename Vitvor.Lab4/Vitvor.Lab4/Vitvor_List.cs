using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.Lab4
{
    class Vitvor_List
    {
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
        public Vitvor_List(int numbers)
        {
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
    }
}
