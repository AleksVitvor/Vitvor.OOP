using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.Lab4
{
    class Error:SystemException
    {
        public Error() : base("Введены неверные данные")
        { }
    }
}
