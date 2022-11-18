namespace BeVelS.Graphics.Recorders.InterfacesAbstractFactories
{
    using BeVelS.Graphics.Recorders.InterfacesFactories;
    using BeVelS.Graphics.Recorders.InterfacesFactories.Configurations;

    public interface IRecordersAbstractFactory
    {
        IAnimatedGifRecorderConfigurationFactory CreateAnimatedGifRecorderConfigurationFactory();

        IAnimatedGifRecorderFactory CreateAnimatedGifRecorderFactory();

        IFrameRecorderConfigurationFactory CreateFrameRecorderConfigurationFactory();

        IFrameRecorderFactory CreateFrameRecorderFactory();
    }
}