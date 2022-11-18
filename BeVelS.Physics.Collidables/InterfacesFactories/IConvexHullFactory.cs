namespace BeVelS.Physics.Collidables.InterfacesFactories
{
    using System;
    using System.Numerics;

    using BepuPhysics.Collidables;

    using BepuUtilities.Memory;

    using BeVelS.Common.Vectors.InterfacesFactories;

    public interface IConvexHullFactory
    {
        ConvexHull Create(
            Span<Vector3> points,
            BufferPool pool,
            out Vector3 center);

        ConvexHull Create(
            BufferPool bufferPool,
            Mesh mesh,
            Vector3 scaling);

        ConvexHull CreateRandom(
            IVector3Factory vector3Factory,
            BufferPool bufferPool,
            int pointCount,
            Vector3 scaling,
            int seed);
    }
}