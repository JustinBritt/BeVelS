namespace BeVelS.Graphics.BufferConstants.Structs.FragmentConstants
{
	using System.Numerics;
    using System.Runtime.InteropServices;

	using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/ShapeDrawing/RayTracedRenderer.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Renamed RayTracedPixelConstants to CapsuleFragmentConstants")]
    [StructLayout(LayoutKind.Explicit, Size = 64)]
	public struct CapsuleFragmentConstants
	{
		[FieldOffset(0)]
		public Vector3 CameraRight;

		[FieldOffset(12)]
		public float NearClip;

		[FieldOffset(16)]
		public Vector3 CameraUp;

		[FieldOffset(28)]
		public float FarClip;

		[FieldOffset(32)]
		public Vector3 CameraBackward;

		[FieldOffset(48)]
		public Vector2 PixelSizeAtUnitPlane;
	}
}