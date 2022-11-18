namespace BeVelS.Graphics.UILines.Structs
{
    using System.Numerics;
    using System.Runtime.CompilerServices;

    using BeVelS.Graphics.Utilities.Classes;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/UI/UILineRenderer.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges)]
    public struct UILineInstance
    {
        /// <summary>
        /// Start location. X is stored in the lower 16 bits, Y in the upper 16. Should be scaled by the PackedToScreenScale.
        /// </summary>
        public uint PackedStart;

        /// <summary>
        /// End location. X is stored in the lower 16 bits, Y in the upper 16. Should be scaled by the PackedToScreenScale.
        /// </summary>
        public uint PackedEnd;

        /// <summary>
        /// Radius of the line in screen pixels.
        /// </summary>
        public float Radius;

        /// <summary>
        /// Color, packed in a UNORM manner such that bits 0 through 10 are R, bits 11 through 21 are G, and bits 22 through 31 are B.
        /// </summary>
        public uint PackedColor;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UILineInstance(
            in Vector2 start,
            in Vector2 end,
            float radius,
            in Vector3 color,
            in Vector2 screenToPackedScale)
        {
            this.PackedStart = (uint)(start.X * screenToPackedScale.X) | ((uint)(start.Y * screenToPackedScale.Y) << 16);

            this.PackedEnd = (uint)(end.X * screenToPackedScale.X) | ((uint)(end.Y * screenToPackedScale.Y) << 16);

            this.Radius = radius;

            this.PackedColor = ColorUtilities.PackColor(
                color);
        }
    }
}