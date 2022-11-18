namespace BeVelS.Physics.TimeSteps.InterfacesFactories
{
    using BeVelS.Physics.TimeSteps.Interfaces;

    public interface IFixedTimestepFactory
    {
        IFixedTimestep Create();
    }
}