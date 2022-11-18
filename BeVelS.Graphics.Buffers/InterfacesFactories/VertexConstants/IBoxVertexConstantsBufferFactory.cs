namespace BeVelS.Graphics.Buffers.InterfacesFactories.VertexConstants
{
    using Veldrid;

    using BeVelS.Graphics.BufferConstants.Structs.VertexConstants;
    using BeVelS.Graphics.Buffers.Interfaces;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;

    public interface IBoxVertexConstantsBufferFactory
    {
        unsafe IConstantsBuffer<BoxVertexConstants> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice);
    }
}