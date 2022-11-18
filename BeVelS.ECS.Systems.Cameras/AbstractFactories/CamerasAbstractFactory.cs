namespace BeVelS.ECS.Systems.Cameras.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Systems.Cameras.Factories;
    using BeVelS.ECS.Systems.Cameras.InterfacesAbstractFactories;
    using BeVelS.ECS.Systems.Cameras.InterfacesFactories;

    public sealed class CamerasAbstractFactory : ICamerasAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CamerasAbstractFactory()
        {
        }

        public ICameraSystemFactory CreateCameraSystemFactory()
        {
            ICameraSystemFactory factory = null;

            try
            {
                factory = new CameraSystemFactory();
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