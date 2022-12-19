namespace BeVelS.Audio.Devices.Windows.InterfacesAbstractFactories
{
    using BeVelS.Audio.Devices.Windows.InterfacesFactories;

    public interface IDevicesAbstractFactory
    {
        IWaveOutDevicesFactory CreateWaveOutDevicesFactory();
    }
}