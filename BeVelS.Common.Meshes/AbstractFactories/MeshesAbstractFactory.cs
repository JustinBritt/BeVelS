namespace BeVelS.Common.Meshes.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Common.Meshes.Factories;
    using BeVelS.Common.Meshes.InterfacesAbstractFactories;
    using BeVelS.Common.Meshes.InterfacesFactories;

    public sealed class MeshesAbstractFactory : IMeshesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MeshesAbstractFactory()
        {
        }

        public IMeshContentFactory CreateMeshContentFactory()
        {
            IMeshContentFactory factory = null;

            try
            {
                factory = new MeshContentFactory();
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