

namespace UnitImplementation
{
    public interface IMovableUnit : IUnit
    {
        
        int WalkingSpeed { get;  }
        void Move();
    }
}
