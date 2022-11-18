namespace BeVelS.Graphics.Glyphs.Structs
{
    using System.Diagnostics;
    using System.Numerics;
    using System.Runtime.CompilerServices;

    using BeVelS.Graphics.Utilities.Classes;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/UI/GlyphRenderer.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Changes to comments")]
    public struct GlyphInstance
    {
        /// <summary>
        /// Packed location of the minimum corner of the glyph. Lower 16 bits is X, upper 16 bits is Y. Should be scaled by PackedToScreen.
        /// </summary>
        public uint PackedMinimum;

        /// <summary>
        /// Packed horizontal axis used by the glyph. Lower 16 bits is X, upper 16 bits is Y. UNORM packed across a range from -1.0 at 0 to 1.0 at 65534.
        /// </summary>
        public uint PackedHorizontalAxis;

        /// <summary>
        /// The combination of two properties: scale to apply to the source glyph. UNORM packed across a range of 0.0 at 0 to 16.0 at 65535, stored in the lower 16 bits,
        /// and the id of the glyph type in the font stored in the upper 16 bits.
        /// </summary>
        public uint PackedScaleAndSourceId;

        /// <summary>
        /// RGBA color, packed in a UNORM manner such that bits 0 through 7 are R, bits 8 through 15 are G, bits 16 through 23 are B, and bits 24 through 31 are A.
        /// </summary>
        public uint PackedColor;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public GlyphInstance(
            ref Vector2 start,
            ref Vector2 horizontalAxis,
            float scale,
            int sourceId,
            ref Vector4 color,
            ref Vector2 screenToPackedScale)
        {
            this.PackedMinimum = (uint)(start.X * screenToPackedScale.X) | ((uint)(start.Y * screenToPackedScale.Y) << 16);
         
            uint scaledAxisX = (uint)(horizontalAxis.X * 32767f + 32767f);
            
            uint scaledAxisY = (uint)(horizontalAxis.Y * 32767f + 32767f);
            
            Debug.Assert(
                scaledAxisX <= 65534);
            
            Debug.Assert(
                scaledAxisY <= 65534);
            
            this.PackedHorizontalAxis = scaledAxisX | (scaledAxisY << 16);
            
            float packScaledScale = scale * (65535f / 16f);
            
            Debug.Assert(
                packScaledScale >= 0);
            
            if (packScaledScale > 65535f)
                packScaledScale = 65535f;
            
            Debug.Assert(
                sourceId >= 0 && sourceId < 65536);
            
            this.PackedScaleAndSourceId = (uint)packScaledScale | (uint)(sourceId << 16);
            
            this.PackedColor = ColorUtilities.PackColor(
                color);
        }
    }
}