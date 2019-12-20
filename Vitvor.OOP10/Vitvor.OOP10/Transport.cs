using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP10
{
    class Transport : IComparable<Transport>
    {
        public int Weight { get; set; }
        public int Capacity { get; set; }

        public int CompareTo(Transport obj)
        {
            if (this.Weight > obj.Weight) return 1;
            if (this.Weight < obj.Weight) return -1;
            else return 0;
        }
        public Transport(int weight, int capacity)
        {
            Weight = weight;
            Capacity = capacity;
        }
        public override string ToString()
        {
            return $"{Weight} {Capacity}";
        }
    }
}