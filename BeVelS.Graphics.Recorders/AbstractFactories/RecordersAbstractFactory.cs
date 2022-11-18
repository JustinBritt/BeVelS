namespace BeVelS.Graphics.Recorders.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Graphics.Recorders.Factories;
    using BeVelS.Graphics.Recorders.Factories.Configurations;
    using BeVelS.Graphics.Recorders.InterfacesAbstractFactories;
    using BeVelS.Graphics.Recorders.InterfacesFactories;
    using BeVelS.Graphics.Recorders.InterfacesFactories.Configurations;

    public sealed class RecordersAbstractFactory : IRecordersAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RecordersAbstractFactory()
        {
        }

        public IAnimatedGifRecorderConfigurationFactory CreateAnimatedGifRecorderConfigurationFactory()
        {
            IAnimatedGifRecorderConfigurationFactory factory = null;

            try
            {
                factory = new AnimatedGifRecorderConfigurationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IAnimatedGifRecorderFactory CreateAnimatedGifRecorderFactory()
        {
            IAnimatedGifRecorderFactory factory = null;

            try
            {
                factory = new AnimatedGifRecorderFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IFrameRecorderConfigurationFactory CreateFrameRecorderConfigurationFactory()
        {
            IFrameRecorderConfigurationFactory factory = null;

            try
            {
                factory = new FrameRecorderConfigurationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IFrameRecorderFactory CreateFrameRecorderFactory()
        {
            IFrameRecorderFactory factory = null;

            try
            {
                factory = new FrameRecorderFactory();
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