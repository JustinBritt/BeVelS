namespace BeVelS.Physics.Collidables.InterfacesFactories
{
    using System;
    using System.Numerics;

    using BepuPhysics.Collidables;

    using BepuUtilities.Memory;

    public interface IMeshFactory
    {
        Mesh Create(
            Span<byte> data,
            BufferPool pool);

        Mesh Create(
            Buffer<Triangle> triangles,
            Vector3 scale,
            BufferPool pool);
    }
}