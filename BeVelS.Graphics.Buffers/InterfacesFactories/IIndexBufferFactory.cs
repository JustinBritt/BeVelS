namespace BeVelS.Graphics.Buffers.InterfacesFactories
{
    using Veldrid;

    using BeVelS.Graphics.Buffers.Interfaces;
    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;

    public interface IIndexBufferFactory
    {
        IIndexBuffer<uint> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            uint[] indices);

        IIndexBuffer<ushort> Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            ushort[] indices);
    }
}