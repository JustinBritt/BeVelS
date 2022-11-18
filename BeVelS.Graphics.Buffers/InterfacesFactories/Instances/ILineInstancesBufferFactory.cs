namespace BeVelS.Graphics.Buffers.InterfacesFactories.Instances
{
    using Veldrid;

    using BeVelS.Graphics.Buffers.Interfaces;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Physics.Constraints.Structs.Lines;

    public interface ILineInstancesBufferFactory
    {
        unsafe IInstancesBuffer<LineInstance> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            int maximumInstancesPerDraw);
    }
}