using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.Lab5
{
    class Element_Of_Control:Box_Button
    {
        public override void Checking()
        {
            if (Console.KeyAvailable)
            {
                Check = true;
            }
            else
                Check = false;
        }

    }
}
