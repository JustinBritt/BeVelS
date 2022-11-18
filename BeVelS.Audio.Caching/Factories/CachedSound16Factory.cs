namespace BeVelS.Audio.Caching.Factories
{
    using System;

    using log4net;

    using BeVelS.Audio.Caching.Classes;
    using BeVelS.Audio.Caching.Interfaces;
    using BeVelS.Audio.Caching.InterfacesFactories;
    using BeVelS.Audio.Readers.InterfacesFactories;
    using BeVelS.Audio.Resamplers.InterfacesFactories;

    internal sealed class CachedSound16Factory : ICachedSound16Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CachedSound16Factory()
        {
        }

        public ICachedSound16 Create(
            IAudioFileReaderFactory audioFileReaderFactory,
            IWdlResamplingSampleProviderFactory wdlResamplingSampleProviderFactory,
            string audioFileName)
        {
            ICachedSound16 cachedSound16 = null;

            try
            {
                cachedSound16 = new CachedSound16(
                    audioFileReaderFactory,
                    wdlResamplingSampleProviderFactory,
                    audioFileName);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return cachedSound16;
        }
    }
}