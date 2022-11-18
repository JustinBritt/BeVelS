namespace BeVelS.Common.Threading.Factories
{
    using System;

    using log4net;

    using BepuUtilities;

    using BeVelS.Common.Threading.Classes;
    using BeVelS.Common.Threading.Interfaces;
    using BeVelS.Common.Threading.InterfacesFactories;

    internal sealed class ThreadDispatcherFactory : IThreadDispatcherFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ThreadDispatcherFactory()
        {
        }

        public IThreadDispatcher Create(
            IThreadCount threadCount)
        {
            IThreadDispatcher threadDispatcher = null;

            try
            {
                threadDispatcher = new ThreadDispatcher(
                    threadCount: threadCount.Value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return threadDispatcher;
        }
    }
}