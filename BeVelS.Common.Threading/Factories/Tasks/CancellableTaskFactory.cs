namespace BeVelS.Common.Threading.Factories.Tasks
{
    using System;

    using log4net;

    using BeVelS.Common.Threading.Classes.Tasks;
    using BeVelS.Common.Threading.Interfaces.Tasks;
    using BeVelS.Common.Threading.InterfacesFactories.Tasks;

    internal sealed class CancellableTaskFactory : ICancellableTaskFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CancellableTaskFactory()
        {
        }

        public ICancellableTask Create(
            Action action)
        {
            ICancellableTask cancellableTask = null;

            try
            {
                cancellableTask = new CancellableTask(
                    action);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return cancellableTask;
        }
    }
}