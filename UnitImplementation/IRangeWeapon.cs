using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitImplementation
{
    public interface IRangeWeapon : IBattleUnitWeapon
    {
        public int Ammunition { get; set; }

        public int Damage();
    }
}
