namespace BeVelS.ECS.Systems.Recorders.InterfacesFactories
{
    using DefaultEcs;

    using BeVelS.ECS.Messages.CommandLists.InterfacesFactories;
    using BeVelS.ECS.Messages.Recorders.InterfacesFactories;
    using BeVelS.ECS.Systems.InterfacesFactories;
    using BeVelS.ECS.Systems.Recorders.Interfaces;

    using BeVelS.Graphics.CommandLists.InterfacesFactories;
    using BeVelS.Graphics.Recorders.Interfaces.Configurations;
    using BeVelS.Graphics.Recorders.InterfacesFactories;

    public interface IRecordingSystemFactory
    {
        IRecordingSystem Create(
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
            World world);
    }
}