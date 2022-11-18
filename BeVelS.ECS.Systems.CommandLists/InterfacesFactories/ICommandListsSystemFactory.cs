namespace BeVelS.ECS.Systems.CommandLists.InterfacesFactories
{
    using DefaultEcs;

    using BeVelS.ECS.Systems.CommandLists.Interfaces;

    public interface ICommandListsSystemFactory
    {
        ICommandListsSystem Create(
            World world);
    }
}