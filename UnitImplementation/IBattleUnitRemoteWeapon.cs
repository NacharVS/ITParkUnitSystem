using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitImplementation
{
    public interface IBattleUnitRemoteWeapon : IBattleUnitWeapon
    {
        public int Arrow { get; set; }
        public int MaxArrow { get;}
    }
}
