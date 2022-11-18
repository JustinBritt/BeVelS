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

    internal sealed class ResolvedColorBufferSystem : IResolvedColorBufferSystem
    {
        public ResolvedColorBufferSystem(
            ITextureFactory textureFactory,
            World world)
        {
            this.TextureFactory = textureFactory;

            this.World = world;

            this.World.Subscribe(
                this);

            Int2 resolution = this.World.GetResolutionLast();

            this.GraphicsDevice = this.World.GetGraphicsDeviceLast();

            this.ResolvedColorBuffer = this.TextureFactory.Create(
                arrayLayers: 1,
                graphicsDevice: this.GraphicsDevice,
                height: (uint)resolution.Y,
                mipLevels: 1,
                pixelFormat: this.GraphicsDevice.SwapchainFramebuffer.ColorTargets[0].Target.Format,
                textureSampleCount: TextureSampleCount.Count1,
                textureUsage: TextureUsage.RenderTarget | TextureUsage.Sampled,
                width: (uint)resolution.X);

            Entity resolvedColorBufferEntity = this.World.CreateEntity();

            ResolvedColorBufferComponent resolvedColorBufferComponent = default;

            resolvedColorBufferComponent.Value = this.ResolvedColorBuffer;

            resolvedColorBufferEntity.Set<ResolvedColorBufferComponent>(
                resolvedColorBufferComponent);
        }

        private ITextureFactory TextureFactory { get; }

        private GraphicsDevice GraphicsDevice { get; }

        public bool IsEnabled { get; set; }

        public Texture ResolvedColorBuffer { get; private set; }

        private World World { get; }

        public void OnResize(
            Int2 resolution)
        {
            this.ResolvedColorBuffer.Dispose();

            this.ResolvedColorBuffer = this.TextureFactory.Create(
                arrayLayers: 1,
                graphicsDevice: this.GraphicsDevice,
                height: (uint)resolution.Y,
                mipLevels: 1,
                pixelFormat: this.GraphicsDevice.SwapchainFramebuffer.ColorTargets[0].Target.Format,
                textureSampleCount: TextureSampleCount.Count1,
                textureUsage: TextureUsage.RenderTarget | TextureUsage.Sampled,
                width: (uint)resolution.X);

            ref ResolvedColorBufferComponent resolvedColorBufferComponent = ref this.World.GetResolvedColorBufferComponentLastRef();

            resolvedColorBufferComponent.Value = this.ResolvedColorBuffer;
        }

        public void Update(
            float state)
        {
            ref ResolvedColorBufferComponent resolvedColorBufferComponent = ref this.World.GetResolvedColorBufferComponentLastRef();

            resolvedColorBufferComponent.Value = this.ResolvedColorBuffer;
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                this.ResolvedColorBuffer.Dispose();
            }
        }
    }
}