namespace BeVelS.ECS.Systems.Framebuffers.Classes
{
    using BepuUtilities;

    using DefaultEcs;
    using DefaultEcs.System;

    using BeVelS.ECS.Systems.Framebuffers.Interfaces;
    using BeVelS.ECS.Systems.Framebuffers.InterfacesFactories;
    using BeVelS.ECS.Systems.InterfacesFactories;
    using BeVelS.ECS.Systems.RenderTargets.Interfaces;
    using BeVelS.ECS.Systems.RenderTargets.InterfacesFactories;

    using BeVelS.Graphics.Framebuffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Textures.InterfacesFactories;

    internal sealed class FramebufferingSystem : IFramebufferingSystem
    {
        public FramebufferingSystem(
            ISequentialSystemFactory sequentialSystemFactory,
            IFramebufferSystemFactory framebufferSystemFactory,
            IResolvedFramebufferSystemFactory resolvedFramebufferSystemFactory,
            IColorBufferSystemFactory colorBufferSystemFactory,
            IDepthBufferSystemFactory depthBufferSystemFactory,
            IResolvedColorBufferSystemFactory resolvedColorBufferSystemFactory,
            IFramebufferDescriptionFactory framebufferDescriptionFactory,
            ITextureFactory textureFactory,
            World world)
        {
            this.FramebufferDescriptionFactory = framebufferDescriptionFactory;

            this.World = world;

            this.World.Subscribe(
                this);

            this.ColorBufferSystem = colorBufferSystemFactory.Create(
                textureFactory,
                this.World);

            this.DepthBufferSystem = depthBufferSystemFactory.Create(
                textureFactory,
                this.World);

            this.FramebufferSystem = framebufferSystemFactory.Create(
                framebufferDescriptionFactory,
                this.World);

            this.ResolvedColorBufferSystem = resolvedColorBufferSystemFactory.Create(
                textureFactory,
                this.World);

            this.ResolvedFramebufferSystem = resolvedFramebufferSystemFactory.Create(
                FramebufferDescriptionFactory,
                this.World);

            this.SequentialSystem = sequentialSystemFactory.Create<float>(
                this.ColorBufferSystem,
                this.DepthBufferSystem,
                this.FramebufferSystem,
                this.ResolvedColorBufferSystem,
                this.ResolvedFramebufferSystem);
        }

        private IFramebufferDescriptionFactory FramebufferDescriptionFactory { get; }

        public IColorBufferSystem ColorBufferSystem { get; }

        public IDepthBufferSystem DepthBufferSystem { get; }

        public IFramebufferSystem FramebufferSystem { get; }

        public bool IsEnabled { get; set; }

        public IResolvedColorBufferSystem ResolvedColorBufferSystem { get; }

        public IResolvedFramebufferSystem ResolvedFramebufferSystem { get; }

        private ISystem<float> SequentialSystem { get; }

        private World World { get; }

        public void OnResize(
            Int2 resolution)
        {
            this.ColorBufferSystem.OnResize(
                resolution);

            this.DepthBufferSystem.OnResize(
                resolution);

            this.FramebufferSystem.OnResize(
                resolution);

            this.ResolvedColorBufferSystem.OnResize(
                resolution);

            this.ResolvedFramebufferSystem.OnResize(
                resolution);
        }

        public void PostUpdate(
            float state)
        {
        }

        public void Update(
            float state)
        {
            this.SequentialSystem.Update(
                state);
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                this.ColorBufferSystem.Dispose();

                this.DepthBufferSystem.Dispose();

                this.FramebufferSystem.Dispose();

                this.ResolvedColorBufferSystem.Dispose();

                this.ResolvedFramebufferSystem.Dispose();

                this.SequentialSystem.Dispose();
            }
        }
    }
}