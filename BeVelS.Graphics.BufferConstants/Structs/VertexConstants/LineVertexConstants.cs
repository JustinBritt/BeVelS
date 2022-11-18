namespace BeVelS.Graphics.BufferConstants.Structs.VertexConstants
{
    using System.Numerics;
    using System.Runtime.InteropServices;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/Constraints/LineRenderer.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Renamed VertexConstants to LineVertexConstants")]
    [StructLayout(LayoutKind.Explicit)]
    public struct LineVertexConstants
    {
        [FieldOffset(0)]
        public Matrix4x4 ViewProjection;

        [FieldOffset(64)]
        public Vector2 NDCToScreenScale;

        [FieldOffset(80)]
        public Vector3 CameraForward;

        [FieldOffset(92)]
        public float TanAnglePerPixel;

        [FieldOffset(96)]
        public Vector3 CameraRight;

        [FieldOffset(112)]
        public Vector3 CameraPosition;
    }
}