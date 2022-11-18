namespace BeVelS.ECS.Systems.PlaybackEngines.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Systems.PlaybackEngines.Factories;
    using BeVelS.ECS.Systems.PlaybackEngines.InterfacesAbstractFactories;
    using BeVelS.ECS.Systems.PlaybackEngines.InterfacesFactories;

    public sealed class PlaybackEnginesAbstractFactory : IPlaybackEnginesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PlaybackEnginesAbstractFactory()
        {
        }

        public IPlaybackEngineSystemFactory CreatePlaybackEngineSystemFactory()
        {
            IPlaybackEngineSystemFactory factory = null;

            try
            {
                factory = new PlaybackEngineSystemFactory();
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