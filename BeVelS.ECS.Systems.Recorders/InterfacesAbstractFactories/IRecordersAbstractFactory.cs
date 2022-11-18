namespace BeVelS.ECS.Systems.Recorders.InterfacesAbstractFactories
{
    using BeVelS.ECS.Systems.Recorders.InterfacesFactories;

    public interface IRecordersAbstractFactory
    {
        IAnimatedGifRecordingSystemFactory CreateAnimatedGifRecordingSystemFactory();

        IFrameRecordingSystemFactory CreateFrameRecordingSystemFactory();

        IRecordingSystemFactory CreateRecordingSystemFactory();
    }
}