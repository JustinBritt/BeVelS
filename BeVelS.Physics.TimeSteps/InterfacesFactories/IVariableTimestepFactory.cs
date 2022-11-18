namespace BeVelS.Physics.TimeSteps.InterfacesFactories
{
    using BeVelS.Physics.TimeSteps.Interfaces;

    public interface IVariableTimestepFactory
    {
        IVariableTimestep Create();
    }
}