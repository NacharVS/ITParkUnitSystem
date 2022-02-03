using System;
using UnitImplementation;


namespace Units
{
    class Footman : Unit, IMovableUnit, IBattleUnit, IBufable
    {
        public Footman(double currentHealth, double maxHealth)
        {
            CurrentHealth = currentHealth;
            MaxHealth = maxHealth;
        }

        private int _armor;
        public int WalkingSpeed => 6;

        public double CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public double Damage { get => 7; set => throw new NotImplementedException(); }
        public int Armor { get => _armor; set => _armor = value; }

        public void Attack(IUnit unit)
        {
            Console.WriteLine($"Footman inflicted {Damage}");
            unit.CurrentHealth -= Damage;
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
    }
}
