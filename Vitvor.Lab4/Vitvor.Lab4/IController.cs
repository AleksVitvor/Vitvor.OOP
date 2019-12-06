using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.Lab4
{
    interface IController<T>
    { 
        string Look(int number);
        void Add(T id);
        void Del(int number);
    }
}
