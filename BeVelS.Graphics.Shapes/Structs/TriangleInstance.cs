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
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/ShapeDrawing/TriangleRenderer.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Removed PackedColor")]
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct TriangleInstance : IShapeInstance
    {
        [FieldOffset(0)]
        public Vector3 A;

        [FieldOffset(12)]
        public float X;

        [FieldOffset(16)]
        public Vector3 B;

        [FieldOffset(28)]
        public float Y;

        [FieldOffset(32)]
        public Vector3 C;

        [FieldOffset(44)]
        public float Z;

        [FieldOffset(48)]
        public Quaternion Orientation;
    }
}