namespace BeVelS.Audio.PlaybackEngines.InterfacesAbstractFactories
{
    using BeVelS.Audio.PlaybackEngines.InterfacesFactories;

    public interface IPlaybackEnginesAbstractFactory
    {
        IAudioPlaybackEngine16Factory CreateAudioPlaybackEngine16Factory();
    }
}