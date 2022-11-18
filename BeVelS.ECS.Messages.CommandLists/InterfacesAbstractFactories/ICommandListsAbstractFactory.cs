namespace BeVelS.ECS.Messages.CommandLists.InterfacesAbstractFactories
{
    using BeVelS.ECS.Messages.CommandLists.InterfacesFactories;

    public interface ICommandListsAbstractFactory
    {
        ICommandListSubmitCommandsMessageFactory CreateCommandListSubmitCommandsMessageFactory();

        ICommandListSubmitCommandsOnPostUpdateMessageFactory CreateCommandListSubmitCommandsOnPostUpdateMessageFactory();

        ICommandListSubmitCommandsOnUpdateMessageFactory CreateCommandListSubmitCommandsOnUpdateMessageFactory();
    }
}