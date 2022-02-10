namespace UnitImplementation
{
    public interface IBattleUnit:IUnit
    {
        void Attack(IUnit unit);
        public int Armor { get; set; }
        void ChangeWeapon(IBattleUnitWeapon newWeapon);  
    }
    
}
