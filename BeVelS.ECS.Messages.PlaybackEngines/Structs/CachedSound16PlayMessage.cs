namespace BeVelS.ECS.Messages.PlaybackEngines.Structs
{
    using BeVelS.Audio.Caching.Interfaces;

    public struct CachedSound16PlayMessage
    {
        public CachedSound16PlayMessage(
            ICachedSound16 cachedSound16)
        {
            this.CachedSound16 = cachedSound16;
        }

        public ICachedSound16 CachedSound16 { get; }
    }
}