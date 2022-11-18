namespace BeVelS.Physics.Meshes.Classes
{
    using System;
    using System.Numerics;

    using BepuPhysics.Collidables;

    using BepuUtilities.Memory;

    using BeVelS.Common.Triangles.Structs;

    using BeVelS.Licensing.Classes;

    using BeVelS.Physics.Collidables.InterfacesFactories;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/Demos/DemoMeshHelper.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Replaced content archive with input triangles")]
    public static class MeshHelper
    {
        public static Mesh LoadModel(
            IMeshFactory meshFactory,
            ITriangleFactory triangleFactory,
            ReadOnlySpan<TriangleContent> inputTriangles,
            BufferPool pool,
            in Vector3 scaling)
        {
            pool.Take<Triangle>(
                inputTriangles.Length,
                out Buffer<Triangle> outputTriangles);

            for (int i = 0; i < inputTriangles.Length; i = i + 1)
            {
                outputTriangles[i] = triangleFactory.Create(
                    a: inputTriangles[i].A,
                    b: inputTriangles[i].B,
                    c: inputTriangles[i].C);
            }

            return meshFactory.Create(
                outputTriangles,
                scaling,
                pool);
        }  
    }
}