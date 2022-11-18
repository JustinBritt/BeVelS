namespace BeVelS.Graphics.BufferConstants.Structs.VertexConstants
{
    using System.Numerics;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/UI/UILineRenderer.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Renamed RasterizedVertexConstants to UILineVertexConstants")]
    public struct UILineVertexConstants
    {
        // Splitting these two scales (Packed->Screen followed by Screen->NDC) makes handling the radius easy, since it's in uniform screen pixels.
        public Vector2 PackedToScreenScale;

        public Vector2 ScreenToNDCScale;
    }
}