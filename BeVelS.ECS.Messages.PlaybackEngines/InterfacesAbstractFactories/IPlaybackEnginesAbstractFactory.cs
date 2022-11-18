namespace BeVelS.ECS.Messages.PlaybackEngines.InterfacesAbstractFactories
{
    using BeVelS.ECS.Messages.PlaybackEngines.InterfacesFactories;

    public interface IPlaybackEnginesAbstractFactory
    {
        ICachedSound16PlayMessageFactory CreateCachedSound16PlayMessageFactory();
    }
}