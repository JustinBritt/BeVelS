namespace BeVelS.Common.Meshes.Classes
{
    using BeVelS.Common.Meshes.Interfaces;
    using BeVelS.Common.Triangles.Structs;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoContentLoader/MeshContent.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Removed ContentType property",
        "Added GetTrianglesRef method")]
    internal sealed class MeshContent : IMeshContent
    {
        public TriangleContent[] Triangles;

        public MeshContent(
            TriangleContent[] triangles)
        {
            this.Triangles = triangles;
        }

        public ref TriangleContent[] GetTrianglesRef()
        {
            return ref Triangles;
        }
    }
}