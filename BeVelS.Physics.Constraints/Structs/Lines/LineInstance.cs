namespace BeVelS.Physics.Constraints.Structs.Lines
{
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using BeVelS.Graphics.Utilities.Classes;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/Constraints/LineRenderer.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges)]
    [StructLayout(LayoutKind.Explicit)]
    public struct LineInstance
    {
        [FieldOffset(0)]
        public Vector3 Start;

        [FieldOffset(12)]
        public uint PackedBackgroundColor;
        
        [FieldOffset(16)]
        public Vector3 End;
        
        [FieldOffset(28)]
        public uint PackedColor;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LineInstance(
            in Vector3 start,
            in Vector3 end,
            in Vector3 color,
            in Vector3 backgroundColor)
        {
            this.Start = start;

            this.PackedBackgroundColor = ColorUtilities.PackColor(
                backgroundColor);
            
            this.End = end;

            this.PackedColor = ColorUtilities.PackColor(
                color);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LineInstance(
            in Vector3 start,
            in Vector3 end,
            uint packedColor,
            uint packedBackgroundColor)
        {
            this.Start = start;
            
            this.PackedBackgroundColor = packedBackgroundColor;
            
            this.End = end;
            
            this.PackedColor = packedColor;
        }
    }
}