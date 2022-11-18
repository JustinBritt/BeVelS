namespace BeVelS.Graphics.Cameras.Extensions
{
    using System.Numerics;

    using BeVelS.Graphics.Cameras.Interfaces;

    public static class CameraExtensions
    {
        public static ICamera WithPitch(
            this ICamera camera,
            float pitch)
        {
            camera.Pitch = pitch;

            return camera;
        }

        public static ICamera WithPosition(
            this ICamera camera,
            Vector3 position)
        {
            camera.Position = position;

            return camera;
        }

        public static ICamera WithYaw(
            this ICamera camera,
            float yaw)
        {
            camera.Yaw = yaw;

            return camera;
        }
    }
}