﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class ColdBeverage : Beverage
    {
        public ColdBeverage(string name, decimal price, double milliliters)
            : base(name, price, milliliters)
        { }
    }
}
