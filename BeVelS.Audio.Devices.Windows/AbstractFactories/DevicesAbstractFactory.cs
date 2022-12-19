namespace BeVelS.Audio.Devices.Windows.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Audio.Devices.Windows.Factories;
    using BeVelS.Audio.Devices.Windows.InterfacesAbstractFactories;
    using BeVelS.Audio.Devices.Windows.InterfacesFactories;

    public sealed class DevicesAbstractFactory : IDevicesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DevicesAbstractFactory()
        {
        }

        public IWaveOutDevicesFactory CreateWaveOutDevicesFactory()
        {
            IWaveOutDevicesFactory factory = null;

            try
            {
                factory = new WaveOutDevicesFactory();
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