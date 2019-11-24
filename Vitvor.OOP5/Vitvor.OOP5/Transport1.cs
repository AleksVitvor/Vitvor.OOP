using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP5
{
    partial class Transport
    {
        private struct MyStruct
        {
            public int struc;
        }
        private enum en { A = 1, B = 2, C = 3 };
        public void Work()
        {
            MyStruct myStruct = new MyStruct();
            myStruct.struc = 1;
        }
    }
}
