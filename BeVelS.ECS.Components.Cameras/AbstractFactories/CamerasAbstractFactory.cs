namespace BeVelS.ECS.Components.Cameras.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Components.Cameras.Factories;
    using BeVelS.ECS.Components.Cameras.InterfacesAbstractFactories;
    using BeVelS.ECS.Components.Cameras.InterfacesFactories;
   
    public sealed class CamerasAbstractFactory : ICamerasAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CamerasAbstractFactory()
        {
        }

        public ICameraComponentFactory CreateCameraComponentFactory()
        {
            ICameraComponentFactory factory = null;

            try
            {
                factory = new CameraComponentFactory();
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