namespace BeVelS.Graphics.Recorders.Factories.Configurations
{
    using System;

    using log4net;

    using BeVelS.Graphics.Recorders.Classes.Configurations;
    using BeVelS.Graphics.Recorders.Interfaces.Configurations;
    using BeVelS.Graphics.Recorders.InterfacesFactories.Configurations;

    internal sealed class FrameRecorderConfigurationFactory : IFrameRecorderConfigurationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FrameRecorderConfigurationFactory()
        {
        }

        public IFrameRecorderConfiguration Create(
            Func<uint, bool> isFrameRecordable)
        {
            IFrameRecorderConfiguration configuration = null;

            try
            {
                configuration = new FrameRecorderConfiguration(
                    isFrameRecordable);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return configuration;
        }
    }
}