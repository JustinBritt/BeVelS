namespace BeVelS.Audio.Caching.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Audio.Caching.Factories;
    using BeVelS.Audio.Caching.InterfacesAbstractFactories;
    using BeVelS.Audio.Caching.InterfacesFactories;

    public sealed class CachingAbstractFactory : ICachingAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CachingAbstractFactory()
        {
        }

        public ICachedSound16Factory CreateCachedSound16Factory()
        {
            ICachedSound16Factory factory = null;

            try
            {
                factory = new CachedSound16Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICachedSoundSampleProvider16Factory CreateCachedSoundSampleProvider16Factory()
        {
            ICachedSoundSampleProvider16Factory factory = null;

            try
            {
                factory = new CachedSoundSampleProvider16Factory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}