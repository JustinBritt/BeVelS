namespace BeVelS.Physics.TimeSteps.InterfacesAbstractFactories
{
    using BeVelS.Physics.TimeSteps.InterfacesFactories;

    public interface ITimeStepsAbstractFactory
    {
        IFixedTimestepFactory CreateFixedTimestepFactory();

        IVariableTimestepFactory CreateVariableTimestepFactory();
    }
}