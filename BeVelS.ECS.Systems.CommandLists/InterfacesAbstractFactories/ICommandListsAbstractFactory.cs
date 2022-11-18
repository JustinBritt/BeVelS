namespace BeVelS.ECS.Systems.CommandLists.InterfacesAbstractFactories
{
    using BeVelS.ECS.Systems.CommandLists.InterfacesFactories;

    public interface ICommandListsAbstractFactory
    {
        ICommandListsSystemFactory CreateCommandListsSystemFactory();
    }
}