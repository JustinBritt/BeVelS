namespace BeVelS.Common.Threading.Factories
{
    using System;
    using System.Threading;

    using log4net;

    using BeVelS.Common.Threading.InterfacesFactories;

    internal sealed class CancellationTokenSourceFactory : ICancellationTokenSourceFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CancellationTokenSourceFactory()
        {
        }

        public CancellationTokenSource Create()
        {
            CancellationTokenSource cancellationTokenSource = null;

            try
            {
                cancellationTokenSource = new CancellationTokenSource();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return cancellationTokenSource;
        }
    }
}