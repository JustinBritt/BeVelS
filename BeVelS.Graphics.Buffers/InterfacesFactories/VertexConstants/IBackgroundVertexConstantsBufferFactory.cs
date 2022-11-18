namespace BeVelS.Graphics.Buffers.InterfacesFactories.VertexConstants
{
    using System.Numerics;

    using Veldrid;

    using BeVelS.Graphics.Buffers.Interfaces;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;

    public interface IBackgroundVertexConstantsBufferFactory
    {
        IConstantsBuffer<Matrix4x4> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice);
    }
}