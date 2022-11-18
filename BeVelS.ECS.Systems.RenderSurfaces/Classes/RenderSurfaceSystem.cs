namespace BeVelS.ECS.Systems.RenderSurfaces.Classes
{
    using System;
    using System.Numerics;

    using DefaultEcs;

    using Veldrid;

    using BeVelS.ECS.Systems.GraphicsDevices.Interfaces;
    using BeVelS.ECS.Systems.GraphicsDevices.InterfacesFactories;
    using BeVelS.ECS.Systems.RenderSurfaces.Interfaces;
    using BeVelS.ECS.Systems.Resolutions.Interfaces;
    using BeVelS.ECS.Systems.Resolutions.InterfacesFactories;

    internal sealed class RenderSurfaceSystem : IRenderSurfaceSystem
    {
        public RenderSurfaceSystem(
            IGraphicsDeviceSystemFactory graphicsDeviceSystemFactory,
            IResolutionSystemFactory resolutionSystemFactory,
            GraphicsDevice graphicsDevice,
            Vector2 resolution,
            World world)
        {
            this.World = world;

            this.World.Subscribe(
                this);

            this.GraphicsDeviceSystem = graphicsDeviceSystemFactory.Create(
                graphicsDevice,
                world);

            this.ResolutionSystem = resolutionSystemFactory.Create(
                resolution,
                this.World);
        }

        public IGraphicsDeviceSystem GraphicsDeviceSystem { get; }

        public bool IsEnabled { get; set; }

        public IResolutionSystem ResolutionSystem { get; }

        private World World { get; }

        public void PostUpdate(
            float state)
        {
            this.GraphicsDeviceSystem.PostUpdate(
                state);
        }

        public void Update(
            float state)
        {
            this.GraphicsDeviceSystem.Update(
                state);

            this.ResolutionSystem.Update(
                state);
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                this.GraphicsDeviceSystem.Dispose();

                this.ResolutionSystem.Dispose();
            }
        }
    }
}