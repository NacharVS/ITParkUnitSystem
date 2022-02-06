using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitImplementation
{
    public interface IChangeWeapon
    {
        void ChangeWeapon(IBattleUnitWeapon newWeapon);
    }
}
