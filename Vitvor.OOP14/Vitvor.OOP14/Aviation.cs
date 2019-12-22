using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP14
{
    [Serializable]
    public class Aviation : IComparable
    {
        public int _Wingspan { get; set; }
        public Aviation(int wingspan)
        {
            _Wingspan = wingspan;
        }
        public Aviation()
        {

        }
        public override string ToString()
        {
            return $"Тип авиация с дальностью полёта {_Wingspan} км";
        }
        public int CompareTo(object obj)
        {
            Aviation aviation = obj as Aviation;
            if (aviation != null)
                return this._Wingspan.CompareTo(aviation._Wingspan);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }
}
