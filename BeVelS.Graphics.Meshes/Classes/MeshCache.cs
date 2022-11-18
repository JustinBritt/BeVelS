namespace BeVelS.Graphics.Meshes.Classes
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;

    using BepuUtilities.Collections;
    using BepuUtilities.Memory;

    using Veldrid;

    using BeVelS.Common.Utilities.Classes;

    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Meshes.Interfaces;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/ShapeDrawing/MeshCache.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Use Veldrid instead of SharpDX")]
    internal sealed class MeshCache : IMeshCache
    {
        struct UploadRequest
        {
            public int Start;

            public int Count;
        }

        Allocator allocator;

        QuickList<UploadRequest> pendingUploads;

        QuickSet<ulong, PrimitiveComparer<ulong>> previouslyAllocatedIds;

        QuickList<ulong> requestedIds;

        Buffer<Vector4> vertices;

        public MeshCache(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            BufferPool pool,
            int initialSizeInVertices = 1 << 22)
        {
            this.Pool = pool;

            pool.TakeAtLeast(
                initialSizeInVertices,
                out vertices);

            this.TriangleBuffer = this.CreateTriangleBuffer(
                bufferDescriptionFactory,
                graphicsDevice,
                initialSizeInVertices);

            this.allocator = new Allocator(
                initialSizeInVertices,
                pool);

            this.pendingUploads = new QuickList<UploadRequest>(
                128,
                pool);

            this.requestedIds = new QuickList<ulong>(
                128,
                pool);

            this.previouslyAllocatedIds = new QuickSet<ulong, PrimitiveComparer<ulong>>(
                256,
                pool);
        }

        public BufferPool Pool { get; private set; }

        public DeviceBuffer TriangleBuffer { get; private set; }

        public unsafe bool TryGetExistingMesh(
            ulong id,
            out int start,
            out Buffer<Vector4> vertices)
        {
            if (allocator.TryGetAllocationRegion(id, out Allocator.Allocation allocation))
            {
                start = (int)allocation.Start;

                vertices = this.vertices.Slice(
                    start,
                    (int)(allocation.End - start));

                return true;
            }

            start = default;

            vertices = default;

            return false;
        }

        public unsafe bool Allocate(
            ulong id,
            int vertexCount,
            out int start,
            out Buffer<Vector4> vertices)
        {
            if (TryGetExistingMesh(id, out start, out vertices))
            {
                return false;
            }

            if (allocator.Allocate(id, vertexCount, out long longStart))
            {
                start = (int)longStart;

                vertices = this.vertices.Slice(
                    start,
                    vertexCount);

                pendingUploads.Add(
                    new UploadRequest { Start = start, Count = vertexCount },
                    Pool);

                return true;
            }

            // Didn't fit. We need to resize.
            int capacity = (int)this.TriangleBuffer.SizeInBytes / (4 * sizeof(float));

            int copyCount = capacity + vertexCount;

            int newSize = 1 << SpanHelper.GetContainingPowerOf2(
                copyCount);

            this.Pool.ResizeToAtLeast(
                ref this.vertices,
                newSize,
                copyCount);

            allocator.Capacity = newSize;

            allocator.Allocate(
                id,
                vertexCount,
                out longStart);

            start = (int)longStart;

            vertices = this.vertices.Slice(
                start,
                vertexCount);

            // A resize forces an upload of everything, so any previous pending uploads are unnecessary.
            pendingUploads.Count = 0;

            pendingUploads.Add(
                new UploadRequest
                {
                    Start = 0,
                    Count = copyCount
                },
                this.Pool);

            return true;
        }

        private unsafe DeviceBuffer CreateTriangleBuffer(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice,
            long initialSizeInVertices)
        {
            return graphicsDevice.ResourceFactory.CreateBuffer(
                bufferDescriptionFactory.Create(
                    (uint)(8 * initialSizeInVertices * Unsafe.SizeOf<Vector4>()),
                    BufferUsage.Dynamic
                    |
                    BufferUsage.StructuredBufferReadOnly,
                    (uint)(Unsafe.SizeOf<Vector4>())));
        }

        public unsafe void FlushPendingUploads(
            IBufferDescriptionFactory bufferDescriptionFactory,
            GraphicsDevice graphicsDevice)
        {
            if (allocator.Capacity * Unsafe.SizeOf<Vector4>() > this.TriangleBuffer.SizeInBytes)
            {
                this.TriangleBuffer = this.CreateTriangleBuffer(
                    bufferDescriptionFactory,
                    graphicsDevice,
                    allocator.Capacity);
            }

            for (int i = 0; i < pendingUploads.Count; ++i)
            {
                ref UploadRequest upload = ref pendingUploads[i];

                this.UpdateTriangleBuffer(
                    graphicsDevice,
                    new Span<Vector4>(vertices.Memory, vertices.Length),
                    (uint)upload.Start,
                    this.TriangleBuffer);
            }

            pendingUploads.Count = 0;

            // Get rid of any stale allocations.
            for (int i = 0; i < requestedIds.Count; ++i)
            {
                previouslyAllocatedIds.FastRemove(
                    requestedIds[i]);
            }

            for (int i = 0; i < previouslyAllocatedIds.Count; ++i)
            {
                allocator.Deallocate(
                    previouslyAllocatedIds[i]);
            }

            previouslyAllocatedIds.FastClear();

            for (int i = 0; i < requestedIds.Count; ++i)
            {
                previouslyAllocatedIds.Add(
                    requestedIds[i],
                    Pool);
            }

            requestedIds.Count = 0;

            // This executes at the end of the frame. The next frame will read the compacted location, which will be valid because the pending upload will be handled.
            if (allocator.IncrementalCompact(out ulong compactedId, out long compactedSize, out long oldStart, out long newStart))
            {
                vertices.CopyTo(
                    (int)oldStart,
                    vertices,
                    (int)newStart,
                    (int)compactedSize);

                pendingUploads.Add(
                    new UploadRequest
                    {
                        Start = (int)newStart,
                        Count = (int)compactedSize
                    },
                    this.Pool);
            }
        }

        private unsafe void UpdateTriangleBuffer(
            GraphicsDevice graphicsDevice,
            ReadOnlySpan<Vector4> instances,
            uint start,
            DeviceBuffer triangleBuffer)
        {
            graphicsDevice.UpdateBuffer(
                triangleBuffer,
                start,
                instances);
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                this.TriangleBuffer.Dispose();

                this.pendingUploads.Dispose(
                    this.Pool);

                this.Pool.Return(
                    ref this.vertices);

                this.requestedIds.Dispose(
                    this.Pool);

                this.previouslyAllocatedIds.Dispose(
                    this.Pool);

                this.allocator.Dispose();
            }
        }

#if DEBUG
        ~MeshCache()
        {
            DisposeUtilities.CheckForUndisposed(
                disposed,
                this);
        }
#endif
    }
}