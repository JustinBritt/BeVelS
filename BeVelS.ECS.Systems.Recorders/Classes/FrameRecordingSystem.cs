namespace BeVelS.ECS.Systems.Recorders.Classes
{
    using DefaultEcs;

    using Veldrid;
    using Veldrid.ECS.Components.Extensions;

    using BeVelS.ECS.Components.Framebuffers.Extensions;
    using BeVelS.ECS.Components.RenderTargets.Extensions;
    using BeVelS.ECS.Messages.CommandLists.InterfacesFactories;
    using BeVelS.ECS.Messages.Recorders.InterfacesFactories;
    using BeVelS.ECS.Systems.Recorders.Interfaces;

    using BeVelS.Graphics.CommandLists.InterfacesFactories;
    using BeVelS.Graphics.Recorders.Interfaces;
    using BeVelS.Graphics.Recorders.Interfaces.Configurations;
    using BeVelS.Graphics.Recorders.InterfacesFactories;

    internal sealed class FrameRecordingSystem : IFrameRecordingSystem
    {
        public FrameRecordingSystem(
            ICommandListSubmitCommandsMessageFactory commandListSubmitCommandsMessageFactory,
            IRecordedFrameAddImageToAnimatedGifMessageFactory recordedFrameAddImageToAnimatedGifMessageFactory,
            ICommandListFactory commandListFactory,
            IFrameRecorderFactory frameRecorderFactory,
            IFrameRecorderConfiguration frameRecorderConfiguration,
            World world)
        {
            this.CommandListFactory = commandListFactory;

            this.CommandListSubmitCommandsMessageFactory = commandListSubmitCommandsMessageFactory;

            this.RecordedFrameAddImageToAnimatedGifMessageFactory = recordedFrameAddImageToAnimatedGifMessageFactory;

            this.FrameRecorderConfiguration = frameRecorderConfiguration;

            this.World = world;

            this.World.Subscribe(
                this);

            this.FrameCount = 0;

            this.FrameRecorder = frameRecorderFactory.Create(
                this.World.GetGraphicsDeviceLast(),
                this.World.GetResolvedColorBufferLast());
        }

        private ICommandListFactory CommandListFactory { get; }

        private ICommandListSubmitCommandsMessageFactory CommandListSubmitCommandsMessageFactory { get; }

        public uint FrameCount { get; private set; }

        public IFrameRecorder FrameRecorder { get; private set; }

        private IFrameRecorderConfiguration FrameRecorderConfiguration { get; }

        public bool IsEnabled { get; set; }

        private IRecordedFrameAddImageToAnimatedGifMessageFactory RecordedFrameAddImageToAnimatedGifMessageFactory { get; }

        private World World { get; }

        public void Update(
            float state)
        {
            if (this.FrameRecorderConfiguration.IsFrameRecordable(this.FrameCount))
            {
                GraphicsDevice graphicsDevice = this.World.GetGraphicsDeviceLast();

                CommandList commandList = this.CommandListFactory.Create(
                    graphicsDevice);

                commandList.Begin();

                commandList.SetFramebuffer(
                    this.World.GetResolvedFramebufferLast());

                this.FrameRecorder.CopyToStagingTexture(
                    commandList: commandList,
                    graphicsDevice: graphicsDevice,
                    sourceTexture: this.World.GetResolvedColorBufferLast());

                commandList.End();

                this.World.Publish(
                    this.CommandListSubmitCommandsMessageFactory.Create(
                        commandList));

                this.World.Publish(
                    this.RecordedFrameAddImageToAnimatedGifMessageFactory.Create(
                        this.FrameRecorder.GetImage(
                            graphicsDevice,
                            this.FrameRecorder.StagingTexture)));
            }

            this.FrameCount++;
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;
            }
        }
    }
}