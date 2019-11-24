using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP5
{
    class DataEcxeption:Exception
    {
        public DataEcxeption() : base("Введены неверные данные")
        { }
        public DataEcxeption(string message) : base(message)
        { }
    }
}
