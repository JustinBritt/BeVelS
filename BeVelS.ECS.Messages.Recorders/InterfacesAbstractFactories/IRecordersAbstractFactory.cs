namespace BeVelS.ECS.Messages.Recorders.InterfacesAbstractFactories
{
    using BeVelS.ECS.Messages.Recorders.InterfacesFactories;

    public interface IRecordersAbstractFactory
    {
        IAnimatedGifSaveMessageFactory CreateAnimatedGifSaveMessageFactory();

        IRecordedFrameAddImageToAnimatedGifMessageFactory CreateRecordedFrameAddImageToAnimatedGifMessageFactory();
    }
}