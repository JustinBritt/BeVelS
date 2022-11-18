namespace BeVelS.ECS.Systems.Recorders.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Systems.Recorders.Factories;
    using BeVelS.ECS.Systems.Recorders.InterfacesAbstractFactories;
    using BeVelS.ECS.Systems.Recorders.InterfacesFactories;

    public sealed class RecordersAbstractFactory : IRecordersAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RecordersAbstractFactory()
        {
        }

        public IAnimatedGifRecordingSystemFactory CreateAnimatedGifRecordingSystemFactory()
        {
            IAnimatedGifRecordingSystemFactory factory = null;

            try
            {
                factory = new AnimatedGifRecordingSystemFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IFrameRecordingSystemFactory CreateFrameRecordingSystemFactory()
        {
            IFrameRecordingSystemFactory factory = null;

            try
            {
                factory = new FrameRecordingSystemFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IRecordingSystemFactory CreateRecordingSystemFactory()
        {
            IRecordingSystemFactory factory = null;

            try
            {
                factory = new RecordingSystemFactory();
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