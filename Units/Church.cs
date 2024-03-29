﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units
{
    class Church : Unit, IBuilding
    {
        public double Wall => 300;

        public double CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }

        public void UnitInfo()
        {
            Console.WriteLine($"health - {CurrentHealth} wall - {Wall}");
        }

        public void Blessing(IMovableUnit unit)
        {
            unit.MaxHealth += unit.MaxHealth * 0.5;//unitMaxhealth = unit maxhealth + unitmaxHealth*0.5
        }
    }
}
