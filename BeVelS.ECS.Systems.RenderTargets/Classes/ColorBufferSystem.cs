namespace BeVelS.ECS.Systems.RenderTargets.Classes
{
    using BepuUtilities;

    using DefaultEcs;

    using Veldrid;
    using Veldrid.ECS.Components.Extensions;

    using BeVelS.ECS.Components.RenderTargets.Extensions;
    using BeVelS.ECS.Components.RenderTargets.Structs;
    using BeVelS.ECS.Components.Resolutions.Extensions;
    using BeVelS.ECS.Systems.RenderTargets.Interfaces;

    using BeVelS.Graphics.Textures.InterfacesFactories;
    
    internal sealed class ColorBufferSystem : IColorBufferSystem
    {
        public ColorBufferSystem(
            ITextureFactory textureFactory,
            World world)
        {
            this.TextureFactory = textureFactory;

            this.World = world;

            this.World.Subscribe(
                this);

            Int2 resolution = this.World.GetResolutionLast();

            this.GraphicsDevice = this.World.GetGraphicsDeviceLast();

            this.ColorBuffer = this.TextureFactory.Create(
                arrayLayers: 1,
                graphicsDevice: this.GraphicsDevice,
                height: (uint)resolution.Y,
                mipLevels: 1,
                pixelFormat: this.GraphicsDevice.SwapchainFramebuffer.ColorTargets[0].Target.Format,
                textureSampleCount: TextureSampleCount.Count4,
                textureUsage: TextureUsage.RenderTarget | TextureUsage.Sampled,
                width: (uint)resolution.X);

            Entity colorBufferEntity = this.World.CreateEntity();

            ColorBufferComponent colorBufferComponent = default;

            colorBufferComponent.Value = this.ColorBuffer;

            colorBufferEntity.Set<ColorBufferComponent>(
                colorBufferComponent);
        }

        private ITextureFactory TextureFactory { get; }

        public Texture ColorBuffer { get; private set; }

        private GraphicsDevice GraphicsDevice { get; }

        public bool IsEnabled { get; set; }

        private World World { get; }

        public void OnResize(
            Int2 resolution)
        {
            this.ColorBuffer.Dispose();

            this.ColorBuffer = this.TextureFactory.Create(
                arrayLayers: 1,
                graphicsDevice: this.GraphicsDevice,
                height: (uint)resolution.Y,
                mipLevels: 1,
                pixelFormat: this.GraphicsDevice.SwapchainFramebuffer.ColorTargets[0].Target.Format,
                textureSampleCount: TextureSampleCount.Count4,
                textureUsage: TextureUsage.Sampled | TextureUsage.RenderTarget,
                width: (uint)resolution.X);

            ref ColorBufferComponent colorBufferComponent = ref this.World.GetColorBufferComponentLastRef();

            colorBufferComponent.Value = this.ColorBuffer;
        }

        public void Update(
            float state)
        {
            ref ColorBufferComponent colorBufferComponent = ref this.World.GetColorBufferComponentLastRef();

            colorBufferComponent.Value = this.ColorBuffer;
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                this.ColorBuffer.Dispose();
            }
        }
    }
}