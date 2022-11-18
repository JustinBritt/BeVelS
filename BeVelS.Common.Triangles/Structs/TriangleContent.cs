namespace BeVelS.Common.Triangles.Structs
{
    using System.Numerics;

    using BeVelS.Licensing.Classes;
    
    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoContentLoader/MeshContent.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Added constructor")]
    public struct TriangleContent
    {
        public Vector3 A;

        public Vector3 B;

        public Vector3 C;

        public TriangleContent(
            Vector3 A,
            Vector3 B,
            Vector3 C)
        {
            this.A = A;

            this.B = B;

            this.C = C;
        }
    }
}