﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public abstract class Equipable : Item
    {
        public abstract void EquipItem();
        public abstract void UnEquipItem();
    }
}