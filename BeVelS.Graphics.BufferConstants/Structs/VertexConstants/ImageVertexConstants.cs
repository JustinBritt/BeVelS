namespace BeVelS.Graphics.BufferConstants.Structs.VertexConstants
{
    using System.Numerics;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/UI/ImageRenderer.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Renamed VertexConstants to ImageVertexConstants")]
    public struct ImageVertexConstants
    {
        public Vector2 PackedToScreenScale;

        public Vector2 ScreenToNDCScale;
    }
}