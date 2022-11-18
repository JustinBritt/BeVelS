namespace BeVelS.ECS.Messages.PlaybackEngines.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Messages.PlaybackEngines.Factories;
    using BeVelS.ECS.Messages.PlaybackEngines.InterfacesAbstractFactories;
    using BeVelS.ECS.Messages.PlaybackEngines.InterfacesFactories;

    public sealed class PlaybackEnginesAbstractFactory : IPlaybackEnginesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PlaybackEnginesAbstractFactory()
        {
        }

        public ICachedSound16PlayMessageFactory CreateCachedSound16PlayMessageFactory()
        {
            ICachedSound16PlayMessageFactory factory = null;

            try
            {
                factory = new CachedSound16PlayMessageFactory();
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