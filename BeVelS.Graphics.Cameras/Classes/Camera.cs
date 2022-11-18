namespace BeVelS.Graphics.Cameras.Classes
{
    using System;
    using System.Numerics;

    using BepuUtilities;

    using BeVelS.Common.Matrices.Extensions;
    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.Cameras.Interfaces;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/Camera.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Use MathF instead of Math",
        "Use GetInverse extension method")]
    internal sealed class Camera : ICamera
    {
        public Camera(
            float aspectRatio,
            float fieldOfView,
            float nearClip,
            float farClip,
            float maximumPitch = MathF.PI * 0.499f)
        {
            this.AspectRatio = aspectRatio;

            this.FieldOfView = fieldOfView;

            this.MaximumPitch = maximumPitch;
            
            this.NearDistance = nearClip;
            
            this.FarDistance = farClip;
        }

        float yaw;
        /// <summary>
        /// Gets or sets the yaw of the camera as a value from -PI to PI. At 0, Forward is aligned with -z. At PI/2, Forward is aligned with +x. In other words, higher values turn right.
        /// </summary>
        public float Yaw
        {
            get 
            { 
                return this.yaw; 
            }
            set
            {
                float revolution = (value + MathF.PI) / (2 * MathF.PI);

                revolution -= MathF.Floor(
                    revolution);
                
                this.yaw = revolution * (MathF.PI * 2) - MathF.PI;
            }
        }

        float pitch;
        /// <summary>
        /// Gets or sets the pitch of the camera, clamped to a value from -MaximumPitch to MaximumPitch. Higher values look downward, lower values look upward.
        /// </summary>
        public float Pitch
        {
            get 
            { 
                return this.pitch; 
            }
            set 
            { 
                this.pitch = Math.Clamp(
                    value,
                    -this.maximumPitch,
                    this.maximumPitch);
            }
        }

        float maximumPitch;
        /// <summary>
        /// Gets or sets the maximum pitch of the camera, a value from 0 to PI / 2.
        /// </summary>
        public float MaximumPitch
        {
            get 
            { 
                return this.maximumPitch; 
            }
            set 
            { 
                this.maximumPitch = Math.Clamp(
                    value,
                    0,
                    MathF.PI / 2);
            }
        }

        public float AspectRatio { get; set; }

        /// <summary>
        /// Gets or sets the vertical field of view of the camera.
        /// </summary>
        public float FieldOfView { get; set; }

        /// <summary>
        /// Gets or sets the near plane of the camera.
        /// </summary>
        public float NearDistance { get; set; }

        /// <summary>
        /// Gets or sets the far plane of the camera.
        /// </summary>
        public float FarDistance { get; set; }

        public Vector3 Position { get; set; }

        public Quaternion OrientationQuaternion
        {
            get
            {
                return Quaternion.CreateFromYawPitchRoll(
                    -this.Yaw, 
                    -this.Pitch,
                    0);
            }
        }

        public Matrix4x4 OrientationMatrix => Matrix4x4.CreateFromQuaternion(this.OrientationQuaternion);

        public Vector3 Backward => Vector3.Transform(Vector3.UnitZ, this.OrientationQuaternion);

        public Vector3 Down => Vector3.Transform(-Vector3.UnitY, this.OrientationQuaternion);

        public Vector3 Forward => Vector3.Transform(-Vector3.UnitZ, this.OrientationQuaternion);

        public Vector3 Left => Vector3.Transform(-Vector3.UnitX, this.OrientationQuaternion);

        public Vector3 Right => Vector3.Transform(Vector3.UnitX, this.OrientationQuaternion);

        public Vector3 Up => Vector3.Transform(Vector3.UnitY, this.OrientationQuaternion);

        public Matrix4x4 WorldMatrix
        {
            get
            {
                Matrix4x4 world = this.OrientationMatrix;

                world.Translation = this.Position;
                
                return world;
            }
        }

        public Matrix4x4 ViewMatrix => this.WorldMatrix.GetInverse();

        public Matrix4x4 ProjectionMatrix
        {
            get
            {
                return Matrix4x4.CreatePerspectiveFieldOfView(
                    this.FieldOfView,
                    this.AspectRatio,
                    this.FarDistance,
                    this.NearDistance);
            }
        }

        public Matrix4x4 ViewProjectionMatrix
        {
            get
            {
                return this.ViewMatrix * this.ProjectionMatrix;
            }
        }

        public Vector3 GetRayDirection(
            IVector2Factory vector2Factory,
            IVector3Factory vector3Factory,
            bool mouseLocked,
            in Vector2 normalizedMousePosition)
        {
            // The ray direction depends on the camera and whether the camera is locked.
            if (mouseLocked)
            {
                return this.Forward;
            }

            float unitPlaneHalfHeight = MathF.Tan(
                this.FieldOfView * 0.5f);

            float unitPlaneHalfWidth = unitPlaneHalfHeight * this.AspectRatio;

            Vector3 localRayDirection = vector3Factory.Create(
                vector2Factory.Create(unitPlaneHalfWidth, unitPlaneHalfHeight) * 2 * vector2Factory.Create(normalizedMousePosition.X - 0.5f, 0.5f - normalizedMousePosition.Y),
                -1);

            QuaternionEx.TransformWithoutOverlap(
                localRayDirection,
                this.OrientationQuaternion,
                out Vector3 rayDirection);

            return rayDirection;
        }
    }
}