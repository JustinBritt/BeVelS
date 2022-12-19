namespace BeVelS.Audio.Devices.Windows.Factories
{
    using System;

    using log4net;

    using BeVelS.Audio.Devices.Windows.Classes;
    using BeVelS.Audio.Devices.Windows.Interfaces;
    using BeVelS.Audio.Devices.Windows.InterfacesFactories;
    
    internal sealed class WaveOutDevicesFactory : IWaveOutDevicesFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WaveOutDevicesFactory()
        {
        }

        public IWaveOutDevices Create()
        {
            IWaveOutDevices instance = null;

            try
            {
                instance = new WaveOutDevices();
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