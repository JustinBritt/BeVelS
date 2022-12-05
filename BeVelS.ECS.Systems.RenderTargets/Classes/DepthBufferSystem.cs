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
    using Vortice.DXGI;

    internal sealed class DepthBufferSystem : IDepthBufferSystem
    {
        public DepthBufferSystem(
            ITextureFactory textureFactory,
            World world)
        {
            this.TextureFactory = textureFactory;

            this.World = world;

            this.World.Subscribe(
                this);

            Int2 resolution = this.World.GetResolutionLast();

            this.GraphicsDevice = this.World.GetGraphicsDeviceLast();

            this.DepthBuffer = this.TextureFactory.Create(
                arrayLayers: 1,
                graphicsDevice: this.GraphicsDevice,
                height: (uint)resolution.Y,
                mipLevels: 1,
                pixelFormat: this.DepthBufferPixelFormat,
                textureSampleCount: TextureSampleCount.Count4,
                textureUsage: TextureUsage.DepthStencil,
                width: (uint)resolution.X);

            Entity depthBufferEntity = this.World.CreateEntity();

            DepthBufferComponent depthBufferComponent = default;

            depthBufferComponent.Value = this.DepthBuffer;

            depthBufferEntity.Set<DepthBufferComponent>(
                depthBufferComponent);
        }

        private ITextureFactory TextureFactory { get; }

        public Texture DepthBuffer { get; private set; }

        private GraphicsDevice GraphicsDevice { get; }

        public PixelFormat DepthBufferPixelFormat => this.GraphicsDevice.MainSwapchain.Framebuffer.DepthTarget.Value.Target.Format;

        public bool IsEnabled { get; set; }

        private World World { get; }

        public void OnResize(
            Int2 resolution)
        {
            this.DepthBuffer.Dispose();

            this.DepthBuffer = this.TextureFactory.Create(
                arrayLayers: 1,
                graphicsDevice: this.GraphicsDevice,
                height: (uint)resolution.Y,
                mipLevels: 1,
                pixelFormat: this.DepthBufferPixelFormat,
                textureSampleCount: TextureSampleCount.Count4,
                textureUsage: TextureUsage.DepthStencil,
                width: (uint)resolution.X);

            ref DepthBufferComponent depthBufferComponent = ref this.World.GetDepthBufferComponentLastRef();

            depthBufferComponent.Value = this.DepthBuffer;
        }

        public void Update(
            float state)
        {
            if (this.IsEnabled)
            {
                ref DepthBufferComponent depthBufferComponent = ref this.World.GetDepthBufferComponentLastRef();

                depthBufferComponent.Value = this.DepthBuffer;
            }    
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                this.DepthBuffer.Dispose();
            }
        }
    }
}