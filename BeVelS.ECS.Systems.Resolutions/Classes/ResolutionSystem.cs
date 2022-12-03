namespace BeVelS.ECS.Systems.Resolutions.Classes
{
    using System.Numerics;

    using DefaultEcs;

    using BeVelS.Common.Vectors.Extensions;

    using BeVelS.ECS.Components.Resolutions.Extensions;
    using BeVelS.ECS.Components.Resolutions.Structs;
    using BeVelS.ECS.Systems.Resolutions.Interfaces;

    internal sealed class ResolutionSystem : IResolutionSystem
    {
        public ResolutionSystem(
            Vector2 resolution,
            World world)
        {
            this.Resolution = resolution;

            this.World = world;

            this.World.Subscribe(
                this);

            Entity resolutionEntity = this.World.CreateEntity();

            ResolutionComponent resolutionComponent = default;

            resolutionComponent.Value = this.Resolution.ToInt2();

            resolutionEntity.Set<ResolutionComponent>(
                resolutionComponent);
        }

        public bool IsEnabled { get; set; }

        public Vector2 Resolution { get; private set; }

        private World World { get; }

        public void Update(
            float state)
        {
            if (this.IsEnabled)
            {
                ref ResolutionComponent resolutionComponent = ref this.World.GetResolutionComponentLastRef();

                resolutionComponent.Value = this.Resolution.ToInt2();
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