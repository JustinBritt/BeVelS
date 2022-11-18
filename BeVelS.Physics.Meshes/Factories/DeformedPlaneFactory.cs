namespace BeVelS.Physics.Meshes.Factories
{
    using System;
    using System.Numerics;

    using BepuPhysics.Collidables;

    using BepuUtilities.Memory;

    using BeVelS.Licensing.Classes;

    using BeVelS.Physics.Collidables.InterfacesFactories;
    using BeVelS.Physics.Meshes.InterfacesFactories;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/Demos/DemoMeshHelper.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges)]
    internal class DeformedPlaneFactory : IDeformedPlaneFactory
    {
        public DeformedPlaneFactory()
        {
        }

        public Mesh Create(
            IMeshFactory meshFactory,
            int width,
            int height,
            Func<int, int, Vector3> deformer,
            Vector3 scaling,
            BufferPool pool)
        {
            pool.Take<Vector3>(
                width * height,
                out Buffer<Vector3> vertices);

            for (int i = 0; i < width; ++i)
            {
                for (int j = 0; j < height; ++j)
                {
                    vertices[width * j + i] = deformer(i, j);
                }
            }

            int quadWidth = width - 1;

            int quadHeight = height - 1;

            int triangleCount = quadWidth * quadHeight * 2;

            pool.Take<Triangle>(
                triangleCount,
                out Buffer<Triangle> triangles);

            for (int i = 0; i < quadWidth; ++i)
            {
                for (int j = 0; j < quadHeight; ++j)
                {
                    int triangleIndex = (j * quadWidth + i) * 2;

                    ref Triangle triangle0 = ref triangles[triangleIndex];
                    
                    ref Vector3 v00 = ref vertices[width * j + i];
                    
                    ref Vector3 v01 = ref vertices[width * j + i + 1];
                    
                    ref Vector3 v10 = ref vertices[width * (j + 1) + i];
                    
                    ref Vector3 v11 = ref vertices[width * (j + 1) + i + 1];
                    
                    triangle0.A = v00;
                    
                    triangle0.B = v01;
                    
                    triangle0.C = v10;
                    
                    ref Triangle triangle1 = ref triangles[triangleIndex + 1];
                    
                    triangle1.A = v01;
                    
                    triangle1.B = v11;
                    
                    triangle1.C = v10;
                }
            }

            pool.Return(
                ref vertices);

            return meshFactory.Create(
                triangles,
                scaling,
                pool);
        }
    }
}