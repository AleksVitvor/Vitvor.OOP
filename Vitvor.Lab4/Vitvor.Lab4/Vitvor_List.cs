using System;
using System.Collections.Generic;

namespace Vitvor.Lab4
{
    class Vitvor_List<T> : IController<T> where T : ObjectInList
    {
        List<T> _lists = new List<T>();
        
        public void Add(T id)
        {
            _lists.Add(id);
        }

        public void Del(int number)
        {
            _lists.RemoveAt(number);
        }

        public string Look(int number)
        {
            return $"Тип список с количеством элементов {_lists.Count} и элемент под номером {number} это {_lists[number].ToString()}";
        }
        public Vitvor_List()
        {
            string _number = Console.ReadLine();
            int number;
            if (!(Int32.TryParse(_number, out number)))
            {
                throw new Error();
            }
            else
            {
                for (int i = 0; i < number; i++) 
                {
                    T objectIn =(T)new ObjectInList();
                    this.Add(objectIn);
                }
            }
        }
}
}