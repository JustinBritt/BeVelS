namespace BeVelS.Graphics.Meshes.Interfaces
{
    using System;
    using System.Numerics;

    using BepuUtilities.Memory;

    using Veldrid;

    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;

    public interface IMeshCache : IDisposable
    {
        DeviceBuffer TriangleBuffer { get; }

        bool Allocate(
            ulong id,
            int vertexCount,
            out int start,
            out Buffer<Vector4> vertices);

        void FlushPendingUploads(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice);

        bool TryGetExistingMesh(
            ulong id,
            out int start,
            out Buffer<Vector4> vertices);
    }
}