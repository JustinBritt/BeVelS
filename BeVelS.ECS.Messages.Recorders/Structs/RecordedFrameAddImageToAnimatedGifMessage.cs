namespace BeVelS.ECS.Messages.Recorders.Structs
{
    using SixLabors.ImageSharp;

    public struct RecordedFrameAddImageToAnimatedGifMessage
    {
        public RecordedFrameAddImageToAnimatedGifMessage(
            Image value)
        {
            this.Value = value;
        }

        public Image Value { get; }
    }
}