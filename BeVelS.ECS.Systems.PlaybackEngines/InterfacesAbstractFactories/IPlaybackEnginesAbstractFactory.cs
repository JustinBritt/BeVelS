namespace BeVelS.ECS.Systems.PlaybackEngines.InterfacesAbstractFactories
{
    using BeVelS.ECS.Systems.PlaybackEngines.InterfacesFactories;

    public interface IPlaybackEnginesAbstractFactory
    {
        IPlaybackEngineSystemFactory CreatePlaybackEngineSystemFactory();
    }
}