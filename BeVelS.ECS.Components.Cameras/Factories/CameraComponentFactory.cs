namespace BeVelS.ECS.Components.Cameras.Factories
{
    using System;

    using log4net;

    using BeVelS.ECS.Components.Cameras.InterfacesFactories;
    using BeVelS.ECS.Components.Cameras.Structs;

    using BeVelS.Graphics.Cameras.Interfaces;

    internal sealed class CameraComponentFactory : ICameraComponentFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CameraComponentFactory()
        {
        }

        public CameraComponent Create(
            ICamera value)
        {
            CameraComponent component = default;

            try
            {
                component = new CameraComponent(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return component;
        }
    }
}