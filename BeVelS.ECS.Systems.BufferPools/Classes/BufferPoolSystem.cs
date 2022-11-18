namespace BeVelS.ECS.Systems.BufferPools.Classes
{
    using BepuUtilities.ECS.Components.Extensions;
    using BepuUtilities.ECS.Components.Structs.Memory;
    using BepuUtilities.Memory;

    using DefaultEcs;

    using BeVelS.Common.Utilities.InterfacesFactories.Memory;

    using BeVelS.ECS.Systems.BufferPools.Interfaces;

    internal sealed class BufferPoolSystem : IBufferPoolSystem
    {
        public BufferPoolSystem(
            IBufferPoolFactory bufferPoolFactory,
            World world)
        {
            this.World = world;

            this.World.Subscribe(
                this);

            this.BufferPool = (BufferPool)bufferPoolFactory.Create();

            Entity bufferPoolEntity = this.World.CreateEntity();

            BufferPoolComponent bufferPoolComponent = default;

            bufferPoolComponent.Value = this.BufferPool;

            bufferPoolEntity.Set<BufferPoolComponent>(
                bufferPoolComponent);
        }

        public BufferPool BufferPool { get; private set; }

        public bool IsEnabled { get; set; }

        public World World { get; }

        public void Update(
            float state)
        {
            ref BufferPoolComponent bufferPoolComponent = ref this.World.GetBufferPoolComponentLastRef();

            bufferPoolComponent.Value = this.BufferPool;
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                this.BufferPool.Clear();
            }
        }
    }
}