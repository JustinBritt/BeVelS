﻿namespace BeVelS.Graphics.BufferConstants.Structs.VertexConstants
{
	using System.Numerics;
    using System.Runtime.InteropServices;

	using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/ShapeDrawing/RasterizedRenderer.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Renamed RasterizedVertexConstants to TriangleVertexConstants")]
    [StructLayout(LayoutKind.Explicit)]
	public struct TriangleVertexConstants
	{
		[FieldOffset(0)]
		public Matrix4x4 Projection;

		[FieldOffset(64)]
		public Vector3 CameraPosition;

		[FieldOffset(80)]
		public Vector3 CameraRight;

		[FieldOffset(96)]
		public Vector3 CameraUp;

		[FieldOffset(112)]
		public Vector3 CameraBackward;
	}
}