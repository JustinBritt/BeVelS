namespace BeVelS.Graphics.BufferConstants.Structs.VertexConstants
{
    using System.Numerics;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/UI/GlyphRenderer.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Renamed VertexConstants to GlyphVertexConstants")]
    public struct GlyphVertexConstants
    {
        public Vector2 PackedToScreenScale;

        public Vector2 ScreenToNDCScale;

        public Vector2 InverseAtlasResolution;
    }
}