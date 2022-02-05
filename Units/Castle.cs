﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;
using Units.BattleUnitsItems;

namespace Units
{
    class Castle : Unit, IBuilding
    {
        public double CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public double Wall { get => 1000; }

        public Peasant CreatePeasant()
        {
            return new Peasant(30, 30);
        }

        public Blacksmith CreateBlacksmith()
        {
            return new Blacksmith(35, 35);
        }

        public Footman CreateFootman(IBattleUnitWeapon weapon)
        {
            return new Footman(60, 60, weapon);
        }

        public Archer CreateArcher(IBattleUnitWeapon weapon, IBattleUnitRemoteWeapon remoteWeapon)
        {
            return new Archer(40, 40, weapon, remoteWeapon);
        }

        public void UnitInfo()
        {
            Console.WriteLine($"health - {CurrentHealth} wall - {Wall}");
        }
    }
}
