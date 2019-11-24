using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP5
{
    class Controller
    {
        public string Find(int wing, List<Aviation> transports)
        {
            for (short i = 0; i < transports.Count; i++)
            {
                if (transports[i]._Wingspan == wing)
                    return $"Найден объект {transports[i].ToString()}";
            }
            return "Объекты не найдены";
        }
    }
}
