namespace BeVelS.ECS.Messages.CommandLists.Structs
{
    using Veldrid;

    public struct CommandListSubmitCommandsOnUpdateMessage
    {
        public CommandListSubmitCommandsOnUpdateMessage(
            CommandList value)
        {
            this.Value = value;
        }

        public CommandList Value { get; }
    }
}