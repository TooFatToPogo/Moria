﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moria
{
    class Sword : Item
    {
        private int damage = 6;

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

    }
}
