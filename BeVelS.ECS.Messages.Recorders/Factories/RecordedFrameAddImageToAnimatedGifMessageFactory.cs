namespace BeVelS.ECS.Messages.Recorders.Factories
{
    using System;

    using log4net;

    using SixLabors.ImageSharp;

    using BeVelS.ECS.Messages.Recorders.InterfacesFactories;
    using BeVelS.ECS.Messages.Recorders.Structs;

    internal sealed class RecordedFrameAddImageToAnimatedGifMessageFactory : IRecordedFrameAddImageToAnimatedGifMessageFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RecordedFrameAddImageToAnimatedGifMessageFactory()
        {
        }

        public RecordedFrameAddImageToAnimatedGifMessage Create(
            Image value)
        {
            RecordedFrameAddImageToAnimatedGifMessage message = default;

            try
            {
                message = new RecordedFrameAddImageToAnimatedGifMessage(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return message;
        }
    }
}