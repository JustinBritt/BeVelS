namespace BeVelS.Graphics.Shapes.Structs
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    using BeVelS.Graphics.Shapes.Interfaces;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/ShapeDrawing/BoxRenderer.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Removed PackedColor",
        "Replaced HalfWidth, HalfHeight, and HalfLength floats with HalfExtents Vector4")]
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct BoxInstance : IShapeInstance
    {
        [FieldOffset(0)]
        public Vector3 Position;

        [FieldOffset(16)]
        public Quaternion Orientation;

        [FieldOffset(32)]
        public Vector4 HalfExtents;
    }
}