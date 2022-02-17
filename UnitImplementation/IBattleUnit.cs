namespace UnitImplementation
{
    public interface IBattleUnit : IUnit
    {
        public int Armor { get; set; }
  
        void Attack(IUnit unit);

        void ChangeWeapon(IBattleUnitWeapon newWeapon);


    }
}
