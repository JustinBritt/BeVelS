namespace BeVelS.Physics.Meshes.InterfacesFactories
{
    using System.Numerics;

    using BepuPhysics.Collidables;

    using BepuUtilities.Memory;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Physics.Collidables.InterfacesFactories;

    public interface IFanFactory
    {
        Mesh Create(
            IVector3Factory vector3Factory,
            IMeshFactory meshFactory,
            int triangleCount,
            float radius,
            Vector3 scaling,
            BufferPool pool);
    }
}