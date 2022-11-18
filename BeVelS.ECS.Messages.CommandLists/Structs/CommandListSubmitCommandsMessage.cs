namespace BeVelS.ECS.Messages.CommandLists.Structs
{
    using Veldrid;

    public struct CommandListSubmitCommandsMessage
    {
        public CommandListSubmitCommandsMessage(
            CommandList value)
        {
            this.Value = value;
        }

        public CommandList Value { get; }
    }
}