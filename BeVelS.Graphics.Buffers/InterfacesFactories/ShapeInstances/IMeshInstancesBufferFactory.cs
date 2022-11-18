namespace BeVelS.Graphics.Buffers.InterfacesFactories.ShapeInstances
{
    using Veldrid;

    using BeVelS.Graphics.Buffers.Interfaces;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shapes.Structs;

    public interface IMeshInstancesBufferFactory
    {
        IShapeInstancesBuffer<MeshInstance> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            int maximumInstancesPerDraw);
    }
}