﻿using System;
using UnitImplementation;


namespace Units
{
    class Footman : Unit, IMovableUnit, IBattleUnit, IBufable
    {
        public Footman(double currentHealth, double maxHealth, IBattleUnitWeapon weaponParameter)
        {
            CurrentHealth = currentHealth;
            MaxHealth = maxHealth;
            _currentWeapon = weaponParameter;
        }


        private int _armor;
        public int WalkingSpeed => 6;

        public double CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public int Armor { get => _armor; set => _armor = value; }

        private IBattleUnitWeapon _currentWeapon;

        public void Attack(IUnit unit)
        {
            Random rnd = new Random();
            var currentDamage = rnd.Next(_currentWeapon.MinDamage, _currentWeapon.MaxDamage);
            Console.WriteLine($"Footman inflicted {currentDamage}");
            unit.CurrentHealth -= currentDamage;
            unit.UnitInfo();
        }

        public void Move()
        {
            Console.WriteLine($"Footman moving with {WalkingSpeed}");
        }

        public void StoneSkin()
        {
            Armor += 10;
            CurrentHealth += 30;
            MaxHealth += 30;
        }

        public void UnitInfo()
        {
            Console.WriteLine($"Footmans health {CurrentHealth} maxHealth {MaxHealth} armor {Armor}");
        }

        public void ChangeWeapon(IBattleUnitWeapon newWeapon)
        {
            _currentWeapon = newWeapon;
        }
    }
}
