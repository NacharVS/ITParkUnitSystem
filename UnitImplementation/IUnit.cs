using System;

namespace UnitImplementation
{
    public interface IUnit
    {
        public double CurrentHealth { get; set; }
        public double MaxHealth { get; set; }

        public void GetWound(double damage);

        void UnitInfo();

        
    }
}
