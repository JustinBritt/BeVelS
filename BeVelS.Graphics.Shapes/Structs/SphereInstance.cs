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
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/ShapeDrawing/RayTracedInstances.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Removed PackedColor")]
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct SphereInstance : IShapeInstance
    {
        [FieldOffset(0)]
        public Vector3 Position;

        [FieldOffset(12)]
        public float Radius;

        [FieldOffset(16)]
        public Vector3 PackedOrientation;
    }
}