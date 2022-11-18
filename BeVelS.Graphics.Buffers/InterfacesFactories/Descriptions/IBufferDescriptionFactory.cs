namespace BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions
{
    using Veldrid;

    public interface IBufferDescriptionFactory
    {
        BufferDescription Create(
            uint sizeInBytes,
            BufferUsage usage);

        BufferDescription Create(
            uint sizeInBytes,
            BufferUsage usage,
            uint structureByteStride);

        BufferDescription Create(
            uint sizeInBytes,
            BufferUsage usage,
            uint structureByteStride,
            bool rawBuffer);
    }
}