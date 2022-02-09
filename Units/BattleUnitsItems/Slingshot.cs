using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitImplementation;

namespace Units.BattleUnitsItems
{
    internal class Slingshot : IRangeWeapon

    {
        private int _stones;
        private double _rangeDamage;
        public int Ammunition { get => _stones; set => _stones = value; }

        public int MinDamage => 1;

        public int MaxDamage => 10;

        public Slingshot(int ammunition)
        {
            Ammunition = ammunition;
        }

        public Slingshot()
        {
            Ammunition = 2;
        }

        public double RangeDamage
        {
            get => _rangeDamage;
            set => this.RangeAttack();
        }

        public double RangeAttack()
        {
            Random rnd = new Random();
            return _rangeDamage = rnd.Next(MinDamage, MaxDamage);
        }
    }
}
