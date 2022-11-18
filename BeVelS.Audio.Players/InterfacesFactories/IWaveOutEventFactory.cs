namespace BeVelS.Audio.Players.InterfacesFactories
{
    using NAudio.Wave;

    public interface IWaveOutEventFactory
    {
        IWavePlayer Create();
    }
}