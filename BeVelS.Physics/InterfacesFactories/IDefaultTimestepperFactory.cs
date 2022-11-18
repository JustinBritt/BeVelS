namespace BeVelS.Physics.InterfacesFactories
{
    using BepuPhysics;

    public interface IDefaultTimestepperFactory
    {
        ITimestepper Create();
    }
}