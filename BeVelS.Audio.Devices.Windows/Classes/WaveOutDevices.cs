namespace BeVelS.Audio.Devices.Windows.Classes
{
    using NAudio.Wave;

    using BeVelS.Audio.Devices.Windows.Interfaces;

    internal sealed class WaveOutDevices : IWaveOutDevices
    {
        public WaveOutDevices()
        {
        }

        public int GetNumberDevices()
        {
            return WaveInterop.waveOutGetNumDevs();
        }
    }
}