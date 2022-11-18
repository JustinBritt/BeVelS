namespace BeVelS.ECS.Systems.Recorders.InterfacesFactories
{
    using DefaultEcs;

    using BeVelS.ECS.Systems.Recorders.Interfaces;

    using BeVelS.Graphics.Recorders.Interfaces.Configurations;
    using BeVelS.Graphics.Recorders.InterfacesFactories;

    public interface IAnimatedGifRecordingSystemFactory
    {
        IAnimatedGifRecordingSystem Create(
            IAnimatedGifRecorderFactory animatedGifRecorderFactory,
            IAnimatedGifRecorderConfiguration animatedGifRecorderConfiguration,
            World world);
    }
}