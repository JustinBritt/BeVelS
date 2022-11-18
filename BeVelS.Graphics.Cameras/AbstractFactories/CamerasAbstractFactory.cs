namespace BeVelS.Graphics.Cameras.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Graphics.Cameras.Factories;
    using BeVelS.Graphics.Cameras.InterfacesAbstractFactories;
    using BeVelS.Graphics.Cameras.InterfacesFactories;

    public sealed class CamerasAbstractFactory : ICamerasAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CamerasAbstractFactory()
        {
        }

        public ICameraFactory CreateCameraFactory()
        {
            ICameraFactory factory = null;

            try
            {
                factory = new CameraFactory();
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