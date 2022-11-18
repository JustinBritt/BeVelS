namespace BeVelS.Graphics.Buffers.InterfacesFactories.ShapeInstances
{
    using Veldrid;

    using BeVelS.Graphics.Buffers.Interfaces;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shapes.Structs;

    public interface ICapsuleInstancesBufferFactory
    {
        IShapeInstancesBuffer<CapsuleInstance> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            int maximumInstancesPerDraw);
    }
}