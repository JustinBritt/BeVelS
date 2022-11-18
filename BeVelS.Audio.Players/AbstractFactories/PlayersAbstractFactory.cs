namespace BeVelS.Audio.Players.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Audio.Players.Factories;
    using BeVelS.Audio.Players.InterfacesAbstractFactories;
    using BeVelS.Audio.Players.InterfacesFactories;

    public sealed class PlayersAbstractFactory : IPlayersAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PlayersAbstractFactory()
        {
        }

        public IWaveOutEventFactory CreateWaveOutEventFactory()
        {
            IWaveOutEventFactory factory = null;

            try
            {
                factory = new WaveOutEventFactory();
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