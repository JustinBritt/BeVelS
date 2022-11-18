namespace BeVelS.ECS.Systems.RenderSurfaces.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using DefaultEcs;

    using Veldrid;

    using BeVelS.ECS.Systems.GraphicsDevices.InterfacesFactories;
    using BeVelS.ECS.Systems.RenderSurfaces.Classes;
    using BeVelS.ECS.Systems.RenderSurfaces.Interfaces;
    using BeVelS.ECS.Systems.RenderSurfaces.InterfacesFactories;
    using BeVelS.ECS.Systems.Resolutions.InterfacesFactories;

    internal sealed class RenderSurfaceSystemFactory : IRenderSurfaceSystemFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RenderSurfaceSystemFactory()
        {
        }

        public IRenderSurfaceSystem Create(
            IGraphicsDeviceSystemFactory graphicsDeviceSystemFactory,
            IResolutionSystemFactory resolutionSystemFactory,
            GraphicsDevice graphicsDevice,
            Vector2 resolution,
            World world)
        {
            IRenderSurfaceSystem system = null;

            try
            {
                system = new RenderSurfaceSystem(
                    graphicsDeviceSystemFactory,
                    resolutionSystemFactory,
                    graphicsDevice,
                    resolution,
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