namespace BeVelS.Graphics.Utilities.Classes
{
    using System.Numerics;
    using System.Runtime.CompilerServices;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/Helpers.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges)]
    public static class ColorUtilities
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint PackColor(
            in Vector3 color)
        {
            const uint RScale = (1 << 11) - 1;

            const uint GScale = (1 << 11) - 1;

            const uint BScale = (1 << 10) - 1;

            uint r = (uint)(color.X * RScale);

            uint g = (uint)(color.Y * GScale);

            uint b = (uint)(color.Z * BScale);

            if (r > RScale)
                r = RScale;

            if (g > GScale)
                g = GScale;

            if (b > BScale)
                b = BScale;

            return r | (g << 11) | (b << 22);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint PackColor(
            in Vector4 color)
        {
            Vector4 scaledColor = Vector4.Max(Vector4.Zero, Vector4.Min(Vector4.One, color)) * 255;

            return (uint)scaledColor.X | ((uint)scaledColor.Y << 8) | ((uint)scaledColor.Z << 16) | ((uint)scaledColor.W << 24);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void UnpackColor(
            uint packedColor,
            out Vector3 color)
        {
            // We don't support any form of alpha, so we dedicate 11 bits to R, 11 bits to G, and 10 bits to B.
            // B is stored in most significant, R in least significant.
            color.X = (packedColor & 0x7FF) / (float)((1 << 11) - 1);

            color.Y = ((packedColor >> 11) & 0x7FF) / (float)((1 << 11) - 1);

            color.Z = ((packedColor >> 22) & 0x3FF) / (float)((1 << 10) - 1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void UnpackColor(
            uint packedColor,
            out Vector4 color)
        {
            color = new Vector4(
                (packedColor & 255) / 255f,
                ((packedColor >> 8) & 255) / 255f,
                ((packedColor >> 16) & 255) / 255f,
                ((packedColor >> 24) & 255) / 255f);
        }
    }
}