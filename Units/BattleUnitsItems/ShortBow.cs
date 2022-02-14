using System;

using UnitImplementation;

namespace Units.BattleUnitsItems
{
    class ShortBow : IRangeWeapon
    {
        private int _arrows;
        private double _rangeDamage;

        public ShortBow()
        {
            Ammunition = 3;
        }

        public ShortBow(int ammunition)
        {
            Ammunition = ammunition;
        }

        public int Ammunition { get => _arrows; set => _arrows = value; }

        public int MinDamage => 2;

        public int MaxDamage => 9;

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
