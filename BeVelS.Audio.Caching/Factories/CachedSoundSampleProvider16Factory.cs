namespace BeVelS.Audio.Caching.Factories
{
    using System;

    using log4net;

    using BeVelS.Audio.Caching.Classes;
    using BeVelS.Audio.Caching.Interfaces;
    using BeVelS.Audio.Caching.InterfacesFactories;

    internal sealed class CachedSoundSampleProvider16Factory : ICachedSoundSampleProvider16Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CachedSoundSampleProvider16Factory()
        {
        }

        public ICachedSoundSampleProvider16 Create(
            ICachedSound16 cachedSound16)
        {
            ICachedSoundSampleProvider16 cachedSoundSampleProvider16 = null;

            try
            {
                cachedSoundSampleProvider16 = new CachedSoundSampleProvider16(
                    cachedSound16);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return cachedSoundSampleProvider16;
        }
    }
}