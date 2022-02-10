namespace UnitImplementation
{
    public interface IRangeUnit : IUnit,IRangeWeapon
    {
        public IRangeWeapon RangeWeapon { get; }
        void Attack(IUnit unit);
    }
}
