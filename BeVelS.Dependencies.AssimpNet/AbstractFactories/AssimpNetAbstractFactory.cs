namespace BeVelS.Dependencies.AssimpNet.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Dependencies.AssimpNet.Factories;
    using BeVelS.Dependencies.AssimpNet.InterfacesAbstractFactories;
    using BeVelS.Dependencies.AssimpNet.InterfacesFactories;

    public sealed class AssimpNetAbstractFactory : IAssimpNetAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public AssimpNetAbstractFactory()
        {
        }

        public IAssimpContextFactory CreateAssimpContextFactory()
        {
            IAssimpContextFactory factory = null;

            try
            {
                factory = new AssimpContextFactory();
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