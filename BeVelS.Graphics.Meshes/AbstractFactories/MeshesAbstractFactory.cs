namespace BeVelS.Graphics.Meshes.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Graphics.Meshes.Factories;
    using BeVelS.Graphics.Meshes.InterfacesAbstractFactories;
    using BeVelS.Graphics.Meshes.InterfacesFactories;

    public sealed class MeshesAbstractFactory : IMeshesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MeshesAbstractFactory()
        {
        }

        public IMeshCacheFactory CreateMeshCacheFactory()
        {
            IMeshCacheFactory factory = null;

            try
            {
                factory = new MeshCacheFactory();
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