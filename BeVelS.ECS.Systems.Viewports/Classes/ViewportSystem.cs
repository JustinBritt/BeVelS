namespace BeVelS.ECS.Systems.Viewports.Classes
{
    using BepuUtilities;

    using DefaultEcs;

    using Veldrid;
    using Veldrid.ECS.Components.Extensions;
    using Veldrid.ECS.Components.Structs;

    using BeVelS.ECS.Components.Resolutions.Extensions;
    using BeVelS.ECS.Systems.Viewports.Interfaces;

    using BeVelS.Graphics.Viewports.InterfacesFactories;

    internal sealed class ViewportSystem : IViewportSystem
    {
        public ViewportSystem(
            IViewportFactory viewportFactory,
            World world)
        {
            this.ViewportFactory = viewportFactory;

            this.World = world;

            this.World.Subscribe(
                this);

            Entity viewportEntity = this.World.CreateEntity();

            ViewportComponent viewportComponent = default;

            viewportComponent.Value = this.Viewport;

            viewportEntity.Set<ViewportComponent>(
                viewportComponent);
        }

        private IViewportFactory ViewportFactory { get; }

        public bool IsEnabled { get; set; }

        public Viewport Viewport { get; private set; }

        private World World { get; }

        public void PostUpdate(
            float state)
        {
        }

        public void Update(
            float state)
        {
            Int2 resolution = this.World.GetResolutionLast();

            this.Viewport = this.ViewportFactory.Create(
                height: resolution.Y,
                maxDepth: 1f,
                minDepth: this.World.GetGraphicsDeviceLast().IsDepthRangeZeroToOne ? 0f : -1f,
                width: resolution.X,
                X: 0f,
                Y: 0f);

            ref ViewportComponent viewportComponent = ref this.World.GetViewportComponentLastRef();

            viewportComponent.Value = this.Viewport;
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;
            }
        }
    }
}