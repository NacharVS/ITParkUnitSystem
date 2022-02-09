﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;
using Units.BattleUnitsItems;

namespace Units 
{
    internal class Archer : Unit, IMovableUnit, IRangeUnit, IBufable 
    {
        //List<IBattleUnitWeapon> weapons = new List<IBattleUnitWeapon>();

        IRangeWeapon _rangeWeapon = new ShortBow(3);
        IBattleUnitWeapon _extraWeapon = new IronShortSword(2, 6);
        IBattleUnitWeapon currentWeapon;

        
        private int _armor;
        public int WalkingSpeed => 8;

        
        
        public double CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public int Armor { get => _armor; set => _armor = value; }
        public IRangeWeapon RangeWeapon { get => _rangeWeapon; set => _rangeWeapon = value; }
                

        public Archer()
        {
            this.currentWeapon = _rangeWeapon;
            //weapons.Add(_rangeWeapon);
            //weapons.Add(_extraWeapon);
        }

        public Archer(IRangeWeapon rangeWeapon)
        {
            _rangeWeapon = rangeWeapon;
            this.currentWeapon = _rangeWeapon;
            //weapons.Add(_rangeWeapon);
            //weapons.Add(_extraWeapon);
        }



        public void Attack(IUnit unit)
        {
            if (_rangeWeapon.Ammunition <= 0)
            {
                Random rnd = new Random();
                var currentDamage = rnd.Next(_extraWeapon.MinDamage, _extraWeapon.MaxDamage);
                Console.WriteLine($"Footman inflicted {currentDamage}");
                unit.CurrentHealth -= currentDamage;
                unit.UnitInfo();
                Console.WriteLine("weapon has changed");
            }
            else
            {
                double currentDamage = this.RangeAttack();
                Console.WriteLine($"Archer inflicted {currentDamage}");
                unit.CurrentHealth -= currentDamage;
                unit.UnitInfo();
            }
        }

        public double RangeAttack()
        {
            double rangeDamage = this.RangeWeapon.RangeAttack();

            Console.WriteLine($"Range Unit - {GetType().Name}  Range damage - {rangeDamage}");
            _rangeWeapon.Ammunition--;
            return rangeDamage;
        }

        public void ChangeWeapon(IBattleUnitWeapon newWeapon)
        {
            currentWeapon = newWeapon;
            //weapons.Add(newWeapon);
        }

        public void Move()
        {
            Console.WriteLine($"Archer moving with {WalkingSpeed}");
        }

        public void StoneSkin()
        {
            Armor += 10;
            CurrentHealth += 30;
            MaxHealth += 30;
        }

        public void UnitInfo()
        {
            Console.WriteLine($"{GetType().Name} health {CurrentHealth} maxHealth {MaxHealth}");
        }
    }
}
