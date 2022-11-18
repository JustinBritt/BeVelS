namespace BeVelS.Common.Utilities.Classes
{   
    using System.Diagnostics;
    using System.Numerics;
    using System.Runtime.CompilerServices;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/Helpers.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges)]
    public static unsafe class QuaternionUtilities
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void PackDuplicateZeroSNORM(
            float source,
            out ushort packed)
        {
            Debug.Assert(source >= -1 && source <= 1);
            
            float magnitude = source * ((1 << 15) - 1);
            
            ref uint reinterpreted = ref Unsafe.As<float, uint>(ref magnitude);
            
            // Cache the sign bit and move it into position.
            int sign = (int)((reinterpreted & 0x8000_0000u) >> 16);

            // Clear the sign bit.
            reinterpreted &= 0x7FFF_FFFF;

            packed = (ushort)((int)magnitude | sign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void PackOrientation(
            in Quaternion source,
            out Vector3 packed)
        {
            packed = new Vector3(
                source.X,
                source.Y,
                source.Z);

            if (source.W < 0)
            {
                packed = -packed;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe ulong PackOrientationU64(
            ref Quaternion source)
        {
            ref Vector4 vectorSource = ref Unsafe.As<float, Vector4>(ref source.X);

            Vector4 clamped = Vector4.Max(
                new Vector4(-1),
                Vector4.Min(
                    Vector4.One,
                    vectorSource));

            ulong packed;

            ref ushort packedShorts = ref Unsafe.As<ulong, ushort>(ref *&packed);

            PackDuplicateZeroSNORM(
                clamped.X,
                out packedShorts);

            PackDuplicateZeroSNORM(
                clamped.Y,
                out Unsafe.Add(
                    ref packedShorts,
                    1));

            PackDuplicateZeroSNORM(
                clamped.Z,
                out Unsafe.Add(
                    ref packedShorts,
                    2));

            PackDuplicateZeroSNORM(
                clamped.W,
                out Unsafe.Add(
                    ref packedShorts,
                    3));

            return packed;
        }
    }
}