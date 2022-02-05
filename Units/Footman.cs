using System;
using UnitImplementation;


namespace Units
{
    class Footman : Unit, IMovableUnit, IBattleUnit, IBufable
    {
        private int _armor;

        IBattleUnitWeapon currentWeapon;

        public Footman(double currentHealth, double maxHealth, IBattleUnitWeapon weaponParameter)
        {
            _currentHealth = currentHealth;
            _maxHealth = maxHealth;
            currentWeapon = weaponParameter;
        }

        public int WalkingSpeed => 6;
        public double CurrentHealth
        {
            get => _currentHealth;
            set
            {
                if (value >= MaxHealth)
                {
                    _currentHealth = MaxHealth;
                }
                else if (value <= 0)
                {
                    _currentHealth = 0;
                }
                else _currentHealth = value;
            }
        }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }
        public int Armor { get => _armor; set => _armor = value; }
        public void Attack(IMovableUnit unit)
        {
            if (currentWeapon != null)
            {
                Random rnd = new Random();
                var currentDamage = rnd.Next(currentWeapon.MinDamage, currentWeapon.MaxDamage);
                Console.WriteLine($"Footman inflicted {currentDamage}");
                unit.GetWound(currentDamage);
            }
            
        }

        public void Move()
        {
            Console.WriteLine($"Footman moving with {WalkingSpeed}");
        }

        public void StoneSkin()
        {
            Armor += 10;
            MaxHealth += 30;
            CurrentHealth += 30;
        }

        public void UnitInfo()
        {
            Console.WriteLine($"Footmans health {CurrentHealth} maxHealth {MaxHealth} armor {Armor}");
        }

        public void ChangeWeapon(IBattleUnitWeapon newWeapon)
        {
            currentWeapon = newWeapon;
        }

        public void GetWound(double damage)
        {
            CurrentHealth -= damage;
        }
    }
}
