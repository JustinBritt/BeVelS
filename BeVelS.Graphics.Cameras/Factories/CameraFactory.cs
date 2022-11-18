namespace BeVelS.Graphics.Cameras.Factories
{
    using System;

    using log4net;

    using BeVelS.Graphics.Cameras.Classes;
    using BeVelS.Graphics.Cameras.Interfaces;
    using BeVelS.Graphics.Cameras.InterfacesFactories;

    internal sealed class CameraFactory : ICameraFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CameraFactory()
        {
        }

        public ICamera Create(
            float aspectRatio,
            float fieldOfView,
            float nearClip,
            float farClip)
        {
            ICamera camera = null;

            try
            {
                camera = new Camera(
                    aspectRatio: aspectRatio,
                    fieldOfView: fieldOfView,
                    nearClip: nearClip,
                    farClip: farClip);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return camera;
        }
    }
}