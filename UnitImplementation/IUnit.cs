namespace UnitImplementation
{
    public interface IUnit
    {
        public double CurrentHealth { get; set; }
        public double MaxHealth { get; set; }
        void UnitInfo();

        
    }
}
