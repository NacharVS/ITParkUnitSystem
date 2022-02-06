using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitImplementation
{
    public interface IBattleUnit:IUnit
    {
        void Attack(IUnit unit);
        public int Armor { get; set; }
        void ChangeWeapon(IBattleUnitWeapon newWeapon);  
    }
    
}
