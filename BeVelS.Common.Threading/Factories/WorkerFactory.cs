namespace BeVelS.Common.Threading.Factories
{
    using System;

    using log4net;

    using BeVelS.Common.Threading.InterfacesFactories;
    using BeVelS.Common.Threading.Structs;

    internal sealed class WorkerFactory : IWorkerFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WorkerFactory()
        {
        }

        public Worker Create()
        {
            Worker worker = default;

            try
            {
                worker = new Worker();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return worker;
        }
    }
}