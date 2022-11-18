namespace BeVelS.Graphics.Fonts.Structs.Characters
{
    using BepuUtilities;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoContentLoader/FontContent.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges)]
    public struct CharacterData
    {
        /// <summary>
        /// Minimum position of a character glyph in the font distance atlas, measured in atlas texels.
        /// (0,0) corresponds to the upper-left corner of the atlas, not the center of the upper left texel.
        /// </summary>
        public Int2 SourceMinimum;

        /// <summary>
        /// Width and height of the glyph in the font distance atlas, measured in atlas texels.
        /// </summary>
        public Int2 SourceSpan;

        /// <summary>
        /// Offset from a starting pen position to the upper left corner of a glyph's target render position in atlas texels.
        /// </summary>
        public Int2 Bearing;

        /// <summary>
        /// Change in horizontal pen position when moving across this character, measured in atlas texels. Does not include any kerning.
        /// </summary>
        public int Advance;

        /// <summary>
        /// The scaling factor to apply to the distance sampled from the glyph's texture data to convert it to texel units.
        /// </summary>
        public float DistanceScale;
    }
}