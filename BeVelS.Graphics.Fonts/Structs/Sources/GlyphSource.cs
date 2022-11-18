namespace BeVelS.Graphics.Fonts.Structs.Sources
{
    using System.Numerics;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/UI/Font.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges)]

    /// <summary>
    /// Location of a glyph in the atlas.
    /// </summary>
    public struct GlyphSource
    {
        public Vector2 Minimum;

        public int PackedSpan;  // Lower 16 bits X, upper 16 bits Y. In texels.

        public float DistanceScale;
    }
}