namespace BeVelS.Physics.Meshes.InterfacesFactories
{
    using System;
    using System.Numerics;

    using BepuPhysics.Collidables;

    using BepuUtilities.Memory;

    using BeVelS.Physics.Collidables.InterfacesFactories;

    public interface IDeformedPlaneFactory
    {
        Mesh Create(
            IMeshFactory meshFactory,
            int width,
            int height,
            Func<int, int, Vector3> deformer,
            Vector3 scaling,
            BufferPool pool);
    }
}