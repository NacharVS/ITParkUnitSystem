using System;
using UnitImplementation;


namespace Units
{
    class Footman : Unit, IMovableUnit, IBattleUnit
    {
        public Footman(double currentHealth, double maxHealth)
        {
            CurrentHealth = currentHealth;
            MaxHealth = maxHealth;
        }

        public int WalkingSpeed => 6;

        public double CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public double Damage { get => 7; set => throw new NotImplementedException(); }

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

        public void UnitInfo()
        {
            Console.WriteLine($"Footmans health {CurrentHealth} maxHealth {MaxHealth}");
        }
    }
}
