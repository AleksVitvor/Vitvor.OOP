﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitvor.OOP5
{
    class PassengerPlaneException:AviatoinException
    {
        public PassengerPlaneException() : base("Неверное количество пассажиров")
        { }
    }
}
