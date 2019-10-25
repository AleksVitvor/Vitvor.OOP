using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.Lab4
{
    static class StaticOperation
    {
        public static ObjectInList Sum(this ObjectInList obj1, ObjectInList obj2)
        {
            ObjectInList obj3 = new ObjectInList(obj1.nameofteam, obj2.nameofcoach, obj1.NumbersOfPlayers+obj2.NumbersOfPlayers);
            return obj3;
        }
        public static int Difference(this Vitvor_List obj1, Vitvor_List obj2)
        {
            return (obj1.Numbers - obj2.Numbers);
        }
    }
}
