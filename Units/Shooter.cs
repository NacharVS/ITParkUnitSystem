using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units
{
   public class Shooter : Unit, IUnit, IMovableUnit, IBattleUnit, IBufable
    {
        public int WalkingSpeed => 5;

        private int _armor;
        public int Armor { get => _armor; set => _armor = value; }

        public double CurrentHealth { get => _currentHealth; set => _currentHealth = value; }
        public double MaxHealth { get => _maxHealth; set => _maxHealth = value; }
       
        IBattleUnitWeapon currentWeapon;
        public Shooter(double currentHealth, double maxHealth, IBattleUnitWeapon weaponParameter)
        {
            CurrentHealth = currentHealth;
            MaxHealth = maxHealth;
            currentWeapon = weaponParameter;
        }
        public void Attack(IUnit unit)
        {
            throw new NotImplementedException();
        }

        public void ChangeWeapon(IBattleUnitWeapon newWeapon)
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void StoneSkin()
        {
            throw new NotImplementedException();
        }

        public void UnitInfo()
        {
            throw new NotImplementedException();
        }
    }
}
