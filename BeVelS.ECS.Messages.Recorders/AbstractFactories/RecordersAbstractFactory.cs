namespace BeVelS.ECS.Messages.Recorders.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Messages.Recorders.Factories;
    using BeVelS.ECS.Messages.Recorders.InterfacesAbstractFactories;
    using BeVelS.ECS.Messages.Recorders.InterfacesFactories;

    public sealed class RecordersAbstractFactory : IRecordersAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RecordersAbstractFactory()
        {
        }

        public IAnimatedGifSaveMessageFactory CreateAnimatedGifSaveMessageFactory()
        {
            IAnimatedGifSaveMessageFactory factory = null;

            try
            {
                factory = new AnimatedGifSaveMessageFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IRecordedFrameAddImageToAnimatedGifMessageFactory CreateRecordedFrameAddImageToAnimatedGifMessageFactory()
        {
            IRecordedFrameAddImageToAnimatedGifMessageFactory factory = null;

            try
            {
                factory = new RecordedFrameAddImageToAnimatedGifMessageFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}