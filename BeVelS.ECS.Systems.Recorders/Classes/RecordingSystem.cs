namespace BeVelS.ECS.Systems.Recorders.Classes
{
    using DefaultEcs;
    using DefaultEcs.System;

    using BeVelS.ECS.Messages.CommandLists.InterfacesFactories;
    using BeVelS.ECS.Messages.Recorders.InterfacesFactories;
    using BeVelS.ECS.Systems.InterfacesFactories;
    using BeVelS.ECS.Systems.Recorders.Interfaces;
    using BeVelS.ECS.Systems.Recorders.InterfacesFactories;

    using BeVelS.Graphics.CommandLists.InterfacesFactories;
    using BeVelS.Graphics.Recorders.Interfaces.Configurations;
    using BeVelS.Graphics.Recorders.InterfacesFactories;

    internal sealed class RecordingSystem : IRecordingSystem
    {
        public RecordingSystem(
            ICommandListSubmitCommandsMessageFactory commandListSubmitCommandsMessageFactory,
            IRecordedFrameAddImageToAnimatedGifMessageFactory recordedFrameAddImageToAnimatedGifMessageFactory,
            ISequentialSystemFactory sequentialSystemFactory,
            IAnimatedGifRecordingSystemFactory animatedGifRecordingSystemFactory,
            IFrameRecordingSystemFactory frameRecordingSystemFactory,
            ICommandListFactory commandListFactory,
            IAnimatedGifRecorderFactory animatedGifRecorderFactory,
            IFrameRecorderFactory frameRecorderFactory,
            IAnimatedGifRecorderConfiguration animatedGifRecorderConfiguration,
            IFrameRecorderConfiguration frameRecorderConfiguration,
            World world)
        {
            this.World = world;

            this.World.Subscribe(
                this);

            this.FrameRecordingSystem = frameRecordingSystemFactory.Create(
                commandListSubmitCommandsMessageFactory,
                recordedFrameAddImageToAnimatedGifMessageFactory,
                commandListFactory,
                frameRecorderFactory,
                frameRecorderConfiguration,
                this.World);

            this.AnimatedGifRecordingSystem = animatedGifRecordingSystemFactory.Create(
                animatedGifRecorderFactory,
                animatedGifRecorderConfiguration,
                this.World);

            this.SequentialSystem = sequentialSystemFactory.Create(
                this.FrameRecordingSystem,
                this.AnimatedGifRecordingSystem);
        }

        public IAnimatedGifRecordingSystem AnimatedGifRecordingSystem { get; }

        public IFrameRecordingSystem FrameRecordingSystem { get; }

        public bool IsEnabled { get; set; }

        private ISystem<float> SequentialSystem { get; }

        private World World { get; }

        public void Update(
            float state)
        {
            this.SequentialSystem.Update(
                state);
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                this.AnimatedGifRecordingSystem.Dispose();

                this.FrameRecordingSystem.Dispose();

                this.SequentialSystem.Dispose();
            }
        }
    }
}