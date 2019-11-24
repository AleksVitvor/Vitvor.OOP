using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP5
{
    class AviatoinException:DataEcxeption
    {
        public AviatoinException():base("Введён неверный размах крыла")
        { }
        public AviatoinException(string message) : base(message)
        { }
    }
}
