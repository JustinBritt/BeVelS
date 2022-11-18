namespace BeVelS.ECS.Systems.Cameras.Factories
{
    using System;

    using log4net;

    using DefaultEcs;

    using BeVelS.ECS.Systems.Cameras.Classes;
    using BeVelS.ECS.Systems.Cameras.Interfaces;
    using BeVelS.ECS.Systems.Cameras.InterfacesFactories;

    using BeVelS.Graphics.Cameras.Interfaces;

    internal sealed class CameraSystemFactory : ICameraSystemFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CameraSystemFactory()
        {
        }

        public ICameraSystem Create(
            ICamera camera,
            World world)
        {
            ICameraSystem system = null;

            try
            {
                system = new CameraSystem(
                    camera,
                    world);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return system;
        }
    }
}