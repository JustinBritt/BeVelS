namespace BeVelS.Graphics.Images.Structs
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
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/UI/ImageRenderer.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Use ColorUtilities")]
    public struct ImageInstance
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
        /// Packed width and height. Width is in the lower 16 bits, height is in the upper 16 bits.
        /// </summary>
        public uint PackedSize;

        /// <summary>
        /// RGBA color, packed in a UNORM manner such that bits 0 through 7 are R, bits 8 through 15 are G, bits 16 through 23 are B, and bits 24 through 31 are A.
        /// </summary>
        public uint PackedColor;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ImageInstance(
            in Vector2 start,
            in Vector2 horizontalAxis,
            in Vector2 size,
            in Vector4 color,
            in Vector2 screenToPackedScale)
        {
            //Note that this can do some weird stuff if the position is outside of the target range. For the sake of the demos, we just assume everything's in frame.
            //If you want to use this for a game where you can't guarantee that everything's in frame, this packing range would need to be modified.
            //One simple option is to just set the mapped region to extend beyond the rendered target. It reduces the precision density a bit, but that's not too important.
            this.PackedMinimum = (uint)(start.X * screenToPackedScale.X) | ((uint)(start.Y * screenToPackedScale.Y) << 16);

            uint scaledAxisX = (uint)(horizontalAxis.X * 32767f + 32767f);
            
            uint scaledAxisY = (uint)(horizontalAxis.Y * 32767f + 32767f);
            
            Debug.Assert(
                scaledAxisX <= 65534);
            
            Debug.Assert(
                scaledAxisY <= 65534);
            
            this.PackedHorizontalAxis = scaledAxisX | (scaledAxisY << 16);
            
            const float sizeScale = 65535f / 4096f;
            
            Vector2 scaledSize = size * sizeScale;
            
            Vector2 clampedSize = Vector2.Max(
                Vector2.Zero,
                Vector2.Min(
                    new Vector2(65535f),
                    scaledSize));
            
            this.PackedSize = (uint)clampedSize.X | (((uint)clampedSize.Y) << 16);
            
            this.PackedColor = ColorUtilities.PackColor(
                color);
        }
    }
}