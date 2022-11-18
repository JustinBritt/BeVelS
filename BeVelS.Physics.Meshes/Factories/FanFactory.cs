namespace BeVelS.Physics.Meshes.Factories
{
    using System;
    using System.Numerics;

    using BepuPhysics.Collidables;

    using BepuUtilities.Memory;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Licensing.Classes;

    using BeVelS.Physics.Collidables.InterfacesFactories;
    using BeVelS.Physics.Meshes.InterfacesFactories;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/Demos/DemoMeshHelper.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges)]
    internal sealed class FanFactory : IFanFactory
    {
        public FanFactory()
        {
        }

        public Mesh Create(
            IVector3Factory vector3Factory,
            IMeshFactory meshFactory,
            int triangleCount,
            float radius,
            Vector3 scaling,
            BufferPool pool)
        {
            float anglePerTriangle = 2 * MathF.PI / triangleCount;

            pool.Take<Triangle>(
                triangleCount,
                out Buffer<Triangle> triangles);

            for (int i = 0; i < triangleCount; ++i)
            {
                float firstAngle = i * anglePerTriangle;

                float secondAngle = ((i + 1) % triangleCount) * anglePerTriangle;

                ref Triangle triangle = ref triangles[i];

                triangle.A = vector3Factory.Create(
                    radius * MathF.Cos(
                        firstAngle),
                    0,
                    radius * MathF.Sin(
                        firstAngle));
                
                triangle.B = vector3Factory.Create(
                    radius * MathF.Cos(
                        secondAngle),
                    0,
                    radius * MathF.Sin(
                        secondAngle));
                
                triangle.C = vector3Factory.Create();
            }

            return meshFactory.Create(
                triangles,
                scaling,
                pool);
        }
    }
}