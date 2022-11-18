namespace BeVelS.Graphics.Buffers.InterfacesFactories.ShapeInstances
{
    using Veldrid;

    using BeVelS.Graphics.Buffers.Interfaces;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shapes.Structs;

    public interface ITriangleInstancesBufferFactory
    {
        IShapeInstancesBuffer<TriangleInstance> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            int maximumInstancesPerDraw);
    }
}