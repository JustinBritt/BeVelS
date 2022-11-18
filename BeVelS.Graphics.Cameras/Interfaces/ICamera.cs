namespace BeVelS.Graphics.Cameras.Interfaces
{
    using System.Numerics;

    using BeVelS.Common.Vectors.InterfacesFactories;

    public interface ICamera
    {
        float AspectRatio { get; set; }

        float FarDistance { get; set; }

        float FieldOfView { get; set; }

        //float MoveSpeed { get; set; }

        float NearDistance { get; set; }

        float Pitch { get; set; }

        Vector3 Position { get; set; }

        Vector3 Backward { get; }

        Vector3 Down { get; }

        Vector3 Forward { get; }

        Vector3 Left { get; }

        Vector3 Right { get; }

        Vector3 Up { get; }

        Matrix4x4 ProjectionMatrix { get; }

        Matrix4x4 ViewMatrix { get; }

        Matrix4x4 ViewProjectionMatrix { get; }

        float Yaw { get; set; }

        Vector3 GetRayDirection(
            IVector2Factory vector2Factory,
            IVector3Factory vector3Factory,
            bool mouseLocked,
            in Vector2 normalizedMousePosition);

        //void Update(
        //  float deltaSeconds);
    }
}