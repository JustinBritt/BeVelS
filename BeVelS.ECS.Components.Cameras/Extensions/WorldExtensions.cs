namespace BeVelS.ECS.Components.Cameras.Extensions
{
    using System.Linq;

    using DefaultEcs;

    using BeVelS.ECS.Components.Cameras.Structs;

    using BeVelS.Graphics.Cameras.Interfaces;

    public static class WorldExtensions
    {
        public static ref CameraComponent GetCameraComponentLastRef(
            this World world)
        {
            return ref world
                .GetEntities()
                .With<CameraComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Last()
                .Get<CameraComponent>();
        }

        public static ICamera GetCameraLast(
            this World world)
        {
            return world
                .GetEntities()
                .With<CameraComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Select(w => w.Get<CameraComponent>().Value)
                .Last();
        }
    }
}