namespace BeVelS.ECS.Systems.CommandLists.Classes
{
    using System.Collections.Generic;

    using DefaultEcs;

    using Veldrid;
    using Veldrid.ECS.Components.Extensions;

    using BeVelS.ECS.Messages.CommandLists.Structs;
    using BeVelS.ECS.Systems.CommandLists.Interfaces;

    internal sealed class CommandListsSystem : ICommandListsSystem
    {
        private List<CommandList> PostUpdateCommandLists;

        private List<CommandList> UpdateCommandLists;

        public CommandListsSystem(
            World world)
        {
            this.PostUpdateCommandLists = new List<CommandList>();

            this.UpdateCommandLists = new List<CommandList>();

            this.World = world;

            this.World.Subscribe(
                this);
        }

        public bool IsEnabled { get; set; }

        private World World { get; }

        [Subscribe]
        private void On(
            in CommandListSubmitCommandsMessage commandListSubmitCommandsMessage)
        {
            GraphicsDevice graphicsDevice = this.World.GetGraphicsDeviceLast();

            CommandList commandList = commandListSubmitCommandsMessage.Value;

            graphicsDevice.SubmitCommands(
                commandList);

            commandList.Dispose();
        }

        [Subscribe]
        private void On(
            in CommandListSubmitCommandsOnPostUpdateMessage commandListSubmitCommandsOnPostUpdateMessage)
        {
            this.PostUpdateCommandLists.Add(
                commandListSubmitCommandsOnPostUpdateMessage.Value);
        }

        [Subscribe]
        private void On(
            in CommandListSubmitCommandsOnUpdateMessage commandListSubmitCommandsOnUpdateMessage)
        {
            this.UpdateCommandLists.Add(
                commandListSubmitCommandsOnUpdateMessage.Value);
        }

        public void PostUpdate(
            float state)
        {
            GraphicsDevice graphicsDevice = this.World.GetGraphicsDeviceLast();

            foreach (CommandList commandList in this.PostUpdateCommandLists)
            {
                graphicsDevice.SubmitCommands(
                    commandList);

                commandList.Dispose();
            }

            this.PostUpdateCommandLists.Clear();
        }

        public void Update(
            float state)
        {
            GraphicsDevice graphicsDevice = this.World.GetGraphicsDeviceLast();

            foreach (CommandList commandList in this.UpdateCommandLists)
            {
                graphicsDevice.SubmitCommands(
                    commandList);

                commandList.Dispose();
            }

            this.UpdateCommandLists.Clear();
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                foreach (CommandList commandList in this.PostUpdateCommandLists)
                {
                    commandList.Dispose();
                }

                foreach (CommandList commandList in this.UpdateCommandLists)
                {
                    commandList.Dispose();
                }
            }
        }
    }
}