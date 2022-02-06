﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units
{
    public class Peasant : Unit, IMovableUnit, IBufable
    {
        public Peasant(double currentHealth, double maxHealth)
        {
            CurrentHealth=currentHealth;
            MaxHealth=maxHealth;
        }
        public double CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }

        public int WalkingSpeed { get=>5 ; }

        public void StoneSkin()
        {
            CurrentHealth += 30;
            MaxHealth += 30;
        }

        public void UnitInfo()
        {
            Console.WriteLine($"{GetType().Name}: health- {CurrentHealth}, maxHealth- {MaxHealth}");
        }

        public void Move()
        {
            Console.WriteLine($"Peasant moving speed {WalkingSpeed}");
        }
    }
}
