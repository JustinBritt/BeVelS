namespace BeVelS.ECS.Messages.CommandLists.InterfacesFactories
{
    using Veldrid;

    using BeVelS.ECS.Messages.CommandLists.Structs;

    public interface ICommandListSubmitCommandsOnUpdateMessageFactory
    {
        CommandListSubmitCommandsOnUpdateMessage Create(
            CommandList value);
    }
}