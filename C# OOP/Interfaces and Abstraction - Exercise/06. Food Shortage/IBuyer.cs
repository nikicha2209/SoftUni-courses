﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._Food_Shortage
{
    public interface IBuyer
    {
        string Name { get; }
        public int Food { get;}

        void BuyFood();
    }
}
