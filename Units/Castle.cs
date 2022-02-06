﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;
using Units.BattleUnitsItem;

namespace Units
{
    class Castle : Unit, IBuilding
    {
        public double CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public double Wall { get => 1000; }

        public Archer CreateArcher(IRangeWeapon rangeWeapon)
        {
            Console.WriteLine($"{GetType().Name} create the Archer");
            return new Archer(rangeWeapon);
        }
        public Blacksmith CreateBlacksmith()
        {
            Console.WriteLine($"{GetType().Name} create the Blacksmith");
            return new Blacksmith(45, 45);
        }
        public Peasant CreatePeasant()
        {
            Console.WriteLine($"{GetType().Name} create the Peasant");
            return new Peasant(30, 30);
        }
        public Footman CreateFootman()
        {
            Console.WriteLine($"{GetType().Name} create the Footman");
            return new Footman(60, 60, new IronShortSword());
        }
        public void UnitInfo()
        {
            Console.WriteLine($"{GetType().Name} health - {CurrentHealth} wall - {Wall}");
        }
        public void ChangeWeapon(IBattleUnitWeapon weapon)
        {

        }
    }
}
