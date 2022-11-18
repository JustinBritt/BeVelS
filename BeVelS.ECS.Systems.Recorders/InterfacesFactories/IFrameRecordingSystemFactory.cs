namespace BeVelS.ECS.Systems.Recorders.InterfacesFactories
{
    using DefaultEcs;

    using BeVelS.ECS.Messages.CommandLists.InterfacesFactories;
    using BeVelS.ECS.Messages.Recorders.InterfacesFactories;
    using BeVelS.ECS.Systems.Recorders.Interfaces;

    using BeVelS.Graphics.CommandLists.InterfacesFactories;
    using BeVelS.Graphics.Recorders.Interfaces.Configurations;
    using BeVelS.Graphics.Recorders.InterfacesFactories;

    public interface IFrameRecordingSystemFactory
    {
        IFrameRecordingSystem Create(
            ICommandListSubmitCommandsMessageFactory commandListSubmitCommandsMessageFactory,
            IRecordedFrameAddImageToAnimatedGifMessageFactory recordedFrameAddImageToAnimatedGifMessageFactory,
            ICommandListFactory commandListFactory,
            IFrameRecorderFactory frameRecorderFactory,
            IFrameRecorderConfiguration frameRecorderConfiguration,
            World world);
    }
}