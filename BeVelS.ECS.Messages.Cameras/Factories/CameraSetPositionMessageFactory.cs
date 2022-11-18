namespace BeVelS.ECS.Messages.Cameras.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BeVelS.ECS.Messages.Cameras.InterfacesFactories;
    using BeVelS.ECS.Messages.Cameras.Structs;

    internal sealed class CameraSetPositionMessageFactory : ICameraSetPositionMessageFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CameraSetPositionMessageFactory()
        {
        }

        public CameraSetPositionMessage Create(
            Vector3 value)
        {
            CameraSetPositionMessage message = default;

            try
            {
                message = new CameraSetPositionMessage(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return message;
        }
    }
}