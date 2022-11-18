namespace BeVelS.Common.Threading.Factories
{
    using System;

    using log4net;

    using BeVelS.Common.Threading.Classes;
    using BeVelS.Common.Threading.Interfaces;
    using BeVelS.Common.Threading.InterfacesFactories;

    internal sealed class ThreadCountFactory : IThreadCountFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ThreadCountFactory()
        {
        }

        public IThreadCount Create(
            int value)
        {
            IThreadCount threadCount = null;

            try
            {
                threadCount = new ThreadCount(
                    value: value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return threadCount;
        }
    }
}