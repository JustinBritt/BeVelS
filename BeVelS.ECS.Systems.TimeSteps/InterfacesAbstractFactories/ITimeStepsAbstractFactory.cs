namespace BeVelS.ECS.Systems.TimeSteps.InterfacesAbstractFactories
{
    using BeVelS.ECS.Systems.TimeSteps.InterfacesFactories;

    public interface ITimeStepsAbstractFactory
    {
        IFixedTimestepSystemFactory CreateFixedTimestepSystemFactory();
    }
}