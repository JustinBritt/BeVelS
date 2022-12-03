namespace BeVelS.ECS.Systems.Recorders.Classes
{
    using DefaultEcs;

    using Veldrid;

    using BeVelS.ECS.Components.RenderTargets.Extensions;
    using BeVelS.ECS.Messages.Recorders.Structs;
    using BeVelS.ECS.Systems.Recorders.Interfaces;

    using BeVelS.Graphics.Recorders.Interfaces;
    using BeVelS.Graphics.Recorders.Interfaces.Configurations;
    using BeVelS.Graphics.Recorders.InterfacesFactories;

    internal sealed class AnimatedGifRecordingSystem : IAnimatedGifRecordingSystem
    {
        public AnimatedGifRecordingSystem(
            IAnimatedGifRecorderFactory animatedGifRecorderFactory,
            IAnimatedGifRecorderConfiguration animatedGifRecorderConfiguration,
            World world)
        {
            this.AnimatedGifRecorderConfiguration = animatedGifRecorderConfiguration;

            this.World = world;

            this.World.Subscribe(
                this);

            Texture resolvedColorBuffer = this.World.GetResolvedColorBufferLast();

            this.AnimatedGifRecorder = animatedGifRecorderFactory.Create(
                height: (int)resolvedColorBuffer.Height,
                width: (int)resolvedColorBuffer.Width);
        }

        public IAnimatedGifRecorder AnimatedGifRecorder { get; private set; }

        private IAnimatedGifRecorderConfiguration AnimatedGifRecorderConfiguration { get; }

        public bool IsEnabled { get; set; }

        private World World { get; }

        [Subscribe]
        private void On(
            in AnimatedGifSaveMessage animatedGifSaveMessage)
        {
            this.AnimatedGifRecorder.Save(
                this.AnimatedGifRecorderConfiguration.OutputPath);
        }

        [Subscribe]
        private void On(
            in RecordedFrameAddImageToAnimatedGifMessage recordedFrameAddImageToAnimatedGifMessage)
        {
            this.AnimatedGifRecorder.AddImage(
                recordedFrameAddImageToAnimatedGifMessage.Value);

            recordedFrameAddImageToAnimatedGifMessage.Value.Dispose();
        }

        public void Update(
            float state)
        {
            if (this.IsEnabled)
            {
            }
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