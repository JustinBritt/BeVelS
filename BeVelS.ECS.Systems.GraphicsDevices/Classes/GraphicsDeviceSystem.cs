namespace BeVelS.ECS.Systems.GraphicsDevices.Classes
{
    using DefaultEcs;

    using Veldrid;
    using Veldrid.ECS.Components.Structs;

    using BeVelS.ECS.Systems.GraphicsDevices.Interfaces;

    internal sealed class GraphicsDeviceSystem : IGraphicsDeviceSystem
    {
        public GraphicsDeviceSystem(
            GraphicsDevice graphicsDevice,
            World world)
        {
            this.GraphicsDevice = graphicsDevice;

            this.World = world;

            this.World.Subscribe(
                this);

            Entity graphicsDeviceEntity = this.World.CreateEntity();

            GraphicsDeviceComponent graphicsDeviceComponent = default;

            graphicsDeviceComponent.Value = this.GraphicsDevice;

            graphicsDeviceEntity.Set<GraphicsDeviceComponent>(
                graphicsDeviceComponent);
        }

        public GraphicsDevice GraphicsDevice { get; private set; }

        public bool IsEnabled { get; set; }

        private World World { get; }

        public void PostUpdate(
            float state)
        {
            if (this.IsEnabled)
            {
                this.GraphicsDevice.SwapBuffers();

                this.GraphicsDevice.WaitForIdle();
            }
        }

        public void Update(
            float state)
        {
            if (this.IsEnabled)
            {
            }
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
            }
        }
    }
}