namespace BeVelS.Audio.Players.Factories
{
    using System;

    using log4net;

    using NAudio.Wave;

    using BeVelS.Audio.Players.InterfacesFactories;
   
    internal sealed class WaveOutEventFactory : IWaveOutEventFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WaveOutEventFactory()
        {
        }

        public IWavePlayer Create()
        {
            IWavePlayer instance = null;

            try
            {
                instance = new WaveOutEvent();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }
    }
}