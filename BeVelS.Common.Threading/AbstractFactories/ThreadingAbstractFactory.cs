namespace BeVelS.Common.Threading.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Common.Threading.Factories;
    using BeVelS.Common.Threading.Factories.Tasks;
    using BeVelS.Common.Threading.InterfacesAbstractFactories;
    using BeVelS.Common.Threading.InterfacesFactories;
    using BeVelS.Common.Threading.InterfacesFactories.Tasks;

    public sealed class ThreadingAbstractFactory : IThreadingAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ThreadingAbstractFactory()
        {
        }

        public ICancellableTaskFactory CreateCancellableTaskFactory()
        {
            ICancellableTaskFactory factory = null;

            try
            {
                factory = new CancellableTaskFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ICancellationTokenSourceFactory CreateCancellationTokenSourceFactory()
        {
            ICancellationTokenSourceFactory factory = null;

            try
            {
                factory = new CancellationTokenSourceFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISimpleTargetThreadCountHeuristicFactory CreateSimpleTargetThreadCountHeuristicFactory()
        {
            ISimpleTargetThreadCountHeuristicFactory factory = null;

            try
            {
                factory = new SimpleTargetThreadCountHeuristicFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IThreadCountFactory CreateThreadCountFactory()
        {
            IThreadCountFactory factory = null;

            try
            {
                factory = new ThreadCountFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IThreadDispatcherFactory CreateThreadDispatcherFactory()
        {
            IThreadDispatcherFactory factory = null;

            try
            {
                factory = new ThreadDispatcherFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IWorkerFactory CreateWorkerFactory()
        {
            IWorkerFactory factory = null;

            try
            {
                factory = new WorkerFactory();
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