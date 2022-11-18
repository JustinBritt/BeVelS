namespace BeVelS.Graphics.Meshes.InterfacesFactories
{
    using Veldrid;

    using BepuUtilities.Memory;

    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Meshes.Interfaces;

    public interface IMeshCacheFactory
    {
        IMeshCache Create(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            BufferPool pool,
            int initialSizeInVertices = 1 << 22);
    }
}