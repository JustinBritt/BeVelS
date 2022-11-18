namespace BeVelS.Dependencies.AssimpNet.Factories
{
    using System;

    using log4net;

    using BeVelS.Dependencies.AssimpNet.InterfacesFactories;

    internal sealed class AssimpContextFactory : IAssimpContextFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public AssimpContextFactory()
        {
        }

        public Assimp.AssimpContext Create()
        {
            Assimp.AssimpContext context = null;

            try
            {
                context = new Assimp.AssimpContext();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return context;
        }
    }
}