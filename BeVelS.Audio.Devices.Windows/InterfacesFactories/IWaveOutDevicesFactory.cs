namespace BeVelS.Audio.Devices.Windows.InterfacesFactories
{
    using BeVelS.Audio.Devices.Windows.Interfaces;

    public interface IWaveOutDevicesFactory
    {
        IWaveOutDevices Create();
    }
}