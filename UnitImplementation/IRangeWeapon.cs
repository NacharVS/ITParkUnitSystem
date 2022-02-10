namespace UnitImplementation
{
    public interface IRangeWeapon:IBattleUnitWeapon
    {
        public int Ammunition { get; set; }
        public int RangeDamage { get; }
        public int RangeAttack();
        
    }
}
