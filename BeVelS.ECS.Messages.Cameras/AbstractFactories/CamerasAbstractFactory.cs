namespace BeVelS.ECS.Messages.Cameras.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Messages.Cameras.Factories;
    using BeVelS.ECS.Messages.Cameras.InterfacesAbstractFactories;
    using BeVelS.ECS.Messages.Cameras.InterfacesFactories;

    public sealed class CamerasAbstractFactory : ICamerasAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CamerasAbstractFactory()
        {
        }

        public ICameraSetPositionMessageFactory CreateCameraSetPositionMessageFactory()
        {
            ICameraSetPositionMessageFactory factory = null;

            try
            {
                factory = new CameraSetPositionMessageFactory();
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