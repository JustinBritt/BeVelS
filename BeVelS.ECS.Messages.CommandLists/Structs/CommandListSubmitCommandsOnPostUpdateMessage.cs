namespace BeVelS.ECS.Messages.CommandLists.Structs
{
    using Veldrid;

    public struct CommandListSubmitCommandsOnPostUpdateMessage
    {
        public CommandListSubmitCommandsOnPostUpdateMessage(
            CommandList value)
        {
            this.Value = value;
        }

        public CommandList Value { get; }
    }
}