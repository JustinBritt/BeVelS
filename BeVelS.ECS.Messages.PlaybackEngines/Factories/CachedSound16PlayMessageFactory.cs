namespace BeVelS.ECS.Messages.PlaybackEngines.Factories
{
    using System;

    using log4net;

    using BeVelS.Audio.Caching.Interfaces;

    using BeVelS.ECS.Messages.PlaybackEngines.InterfacesFactories;
    using BeVelS.ECS.Messages.PlaybackEngines.Structs;

    internal sealed class CachedSound16PlayMessageFactory : ICachedSound16PlayMessageFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CachedSound16PlayMessageFactory()
        {
        }

        public CachedSound16PlayMessage Create(
            ICachedSound16 cachedSound16)
        {
            CachedSound16PlayMessage message = default;

            try
            {
                message = new CachedSound16PlayMessage(
                    cachedSound16);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return message;
        }
    }
}