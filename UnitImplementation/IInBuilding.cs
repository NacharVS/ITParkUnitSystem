using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitImplementation
{
    public interface IInBuilding
    {
        public int MaxGarrison { get;}

        public void ReloadBuilding(IBattleRemoteUnit unit);
    }
}
