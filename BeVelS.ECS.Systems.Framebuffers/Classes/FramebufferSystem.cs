namespace BeVelS.ECS.Systems.Framebuffers.Classes
{
    using BepuUtilities;

    using DefaultEcs;

    using Veldrid;
    using Veldrid.ECS.Components.Extensions;
    using Veldrid.ECS.Components.Structs;

    using BeVelS.ECS.Components.RenderTargets.Extensions;
    using BeVelS.ECS.Systems.Framebuffers.Interfaces;
    
    using BeVelS.Graphics.Framebuffers.InterfacesFactories.Descriptions;

    internal sealed class FramebufferSystem : IFramebufferSystem
    {
        public FramebufferSystem(
            IFramebufferDescriptionFactory framebufferDescriptionFactory,
            World world)
        {
            this.FramebufferDescriptionFactory = framebufferDescriptionFactory;

            this.World = world;

            this.World.Subscribe(
                this);

            this.Framebuffer = this.World.GetGraphicsDeviceLast().ResourceFactory.CreateFramebuffer(
                framebufferDescriptionFactory.Create(
                    this.World.GetDepthBufferLast(),
                    this.World.GetColorBufferLast()));

            Entity framebufferEntity = this.World.CreateEntity();

            FramebufferComponent framebufferComponent = default;

            framebufferComponent.Value = this.Framebuffer;

            framebufferEntity.Set<FramebufferComponent>(
                framebufferComponent);
        }

        private IFramebufferDescriptionFactory FramebufferDescriptionFactory { get; }

        public Framebuffer Framebuffer { get; private set; }

        public bool IsEnabled { get; set; }

        private World World { get; }

        public void OnResize(
            Int2 resolution)
        {
            this.Framebuffer = this.World.GetGraphicsDeviceLast().ResourceFactory.CreateFramebuffer(
                this.FramebufferDescriptionFactory.Create(
                    this.World.GetDepthBufferLast(),
                    this.World.GetColorBufferLast()));

            ref FramebufferComponent framebufferComponent = ref this.World.GetFramebufferComponentLastRef();

            framebufferComponent.Value = this.Framebuffer;
        }

        public void Update(
            float state)
        {
            ref FramebufferComponent framebufferComponent = ref this.World.GetFramebufferComponentLastRef();

            framebufferComponent.Value = this.Framebuffer;
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                this.Framebuffer.Dispose();
            }
        }
    }
}