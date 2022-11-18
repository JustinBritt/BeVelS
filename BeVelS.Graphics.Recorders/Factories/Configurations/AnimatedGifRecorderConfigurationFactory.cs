namespace BeVelS.Graphics.Recorders.Factories.Configurations
{
    using System;

    using log4net;

    using BeVelS.Graphics.Recorders.Classes.Configurations;
    using BeVelS.Graphics.Recorders.Interfaces.Configurations;
    using BeVelS.Graphics.Recorders.InterfacesFactories.Configurations;

    internal sealed class AnimatedGifRecorderConfigurationFactory : IAnimatedGifRecorderConfigurationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public AnimatedGifRecorderConfigurationFactory()
        {
        }

        public IAnimatedGifRecorderConfiguration Create(
            string outputDirectory)
        {
            IAnimatedGifRecorderConfiguration configuration = null;

            try
            {
                configuration = new AnimatedGifRecorderConfiguration(
                    outputDirectory);
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