namespace BeVelS.ECS.Systems.Framebuffers.Classes
{
    using BepuUtilities;

    using DefaultEcs;

    using Veldrid;
    using Veldrid.ECS.Components.Extensions;

    using BeVelS.ECS.Components.Framebuffers.Extensions;
    using BeVelS.ECS.Components.Framebuffers.Structs;
    using BeVelS.ECS.Components.RenderTargets.Extensions;
    using BeVelS.ECS.Systems.Framebuffers.Interfaces;

    using BeVelS.Graphics.Framebuffers.InterfacesFactories.Descriptions;

    internal sealed class ResolvedFramebufferSystem : IResolvedFramebufferSystem
    {
        public ResolvedFramebufferSystem(
            IFramebufferDescriptionFactory framebufferDescriptionFactory,
            World world)
        {
            this.FramebufferDescriptionFactory = framebufferDescriptionFactory;

            this.World = world;

            this.World.Subscribe(
                this);

            this.ResolvedFramebuffer = this.World.GetGraphicsDeviceLast().ResourceFactory.CreateFramebuffer(
                framebufferDescriptionFactory.Create(
                    this.World.GetDepthBufferLast(),
                    this.World.GetResolvedColorBufferLast()));

            Entity resolvedFramebufferEntity = this.World.CreateEntity();

            ResolvedFramebufferComponent resolvedFramebufferComponent = default;

            resolvedFramebufferComponent.Value = this.ResolvedFramebuffer;

            resolvedFramebufferEntity.Set<ResolvedFramebufferComponent>(
                resolvedFramebufferComponent);
        }

        private IFramebufferDescriptionFactory FramebufferDescriptionFactory { get; }

        public bool IsEnabled { get; set; }

        public Framebuffer ResolvedFramebuffer { get; private set; }

        private World World { get; }

        public void OnResize(
            Int2 resolution)
        {
            this.ResolvedFramebuffer.Dispose();

            this.ResolvedFramebuffer = this.World.GetGraphicsDeviceLast().ResourceFactory.CreateFramebuffer(
                this.FramebufferDescriptionFactory.Create(
                    this.World.GetDepthBufferLast(),
                    this.World.GetResolvedColorBufferLast()));

            ref ResolvedFramebufferComponent resolvedFramebufferComponent = ref this.World.GetResolvedFramebufferComponentLastRef();

            resolvedFramebufferComponent.Value = this.ResolvedFramebuffer;
        }

        public void Update(
            float state)
        {
            if (this.IsEnabled)
            {
                ref ResolvedFramebufferComponent resolvedFramebufferComponent = ref this.World.GetResolvedFramebufferComponentLastRef();

                resolvedFramebufferComponent.Value = this.ResolvedFramebuffer;
            }   
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                this.ResolvedFramebuffer.Dispose();
            }
        }
    }
}