using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP5
{
    class Aviation: Transport, IComparable
    {
        private int Wingspan;
        public int _Wingspan
        {
            get
            {
                return Wingspan;
            }
            set
            {
                if(value>0)
                {
                    Wingspan = value;
                }
                else
                {
                    throw new AviatoinException();
                }
            }
        }
        public Aviation()
        {
            Console.WriteLine("Введите дальность полёта");
            _Wingspan = Convert.ToInt32(Console.ReadLine());
        }
        public override string ToString()
        {
            return $"Тип авиация с дальностью полёта {_Wingspan} км";
        }
        public int CompareTo(object obj)
        {
            Aviation aviation = obj as Aviation;
            if (aviation != null)
                return this.Wingspan.CompareTo(aviation.Wingspan);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }
}
