namespace BeVelS.ECS.Messages.Recorders.InterfacesFactories
{
    using SixLabors.ImageSharp;

    using BeVelS.ECS.Messages.Recorders.Structs;

    public interface IRecordedFrameAddImageToAnimatedGifMessageFactory
    {
        RecordedFrameAddImageToAnimatedGifMessage Create(
            Image value);
    }
}