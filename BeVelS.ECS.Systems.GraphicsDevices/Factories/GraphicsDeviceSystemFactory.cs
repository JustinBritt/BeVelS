namespace BeVelS.ECS.Systems.GraphicsDevices.Factories
{
    using System;

    using log4net;

    using DefaultEcs;

    using Veldrid;

    using BeVelS.ECS.Systems.GraphicsDevices.Classes;
    using BeVelS.ECS.Systems.GraphicsDevices.Interfaces;
    using BeVelS.ECS.Systems.GraphicsDevices.InterfacesFactories;

    internal sealed class GraphicsDeviceSystemFactory : IGraphicsDeviceSystemFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public GraphicsDeviceSystemFactory()
        {
        }

        public IGraphicsDeviceSystem Create(
            GraphicsDevice graphicsDevice,
            World world)
        {
            IGraphicsDeviceSystem system = null;

            try
            {
                system = new GraphicsDeviceSystem(
                    graphicsDevice,
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