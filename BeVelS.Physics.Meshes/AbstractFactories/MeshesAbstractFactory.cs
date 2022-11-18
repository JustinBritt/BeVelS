namespace BeVelS.Physics.Meshes.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Physics.Meshes.Factories;
    using BeVelS.Physics.Meshes.InterfacesAbstractFactories;
    using BeVelS.Physics.Meshes.InterfacesFactories;

    public sealed class MeshesAbstractFactory : IMeshesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MeshesAbstractFactory()
        {
        }

        public IDeformedPlaneFactory CreateDeformedPlaneFactory()
        {
            IDeformedPlaneFactory factory = null;

            try
            {
                factory = new DeformedPlaneFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IFanFactory CreateFanFactory()
        {
            IFanFactory factory = null;

            try
            {
                factory = new FanFactory();
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