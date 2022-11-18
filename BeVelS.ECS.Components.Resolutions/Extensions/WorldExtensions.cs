namespace BeVelS.ECS.Components.Resolutions.Extensions
{
    using System.Linq;

    using BepuUtilities;

    using DefaultEcs;

    using BeVelS.ECS.Components.Resolutions.Structs;

    public static class WorldExtensions
    {
        public static ref ResolutionComponent GetResolutionComponentLastRef(
            this World world)
        {
            return ref world
                .GetEntities()
                .With<ResolutionComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Last()
                .Get<ResolutionComponent>();
        }

        public static Int2 GetResolutionLast(
            this World world)
        {
            return world
                .GetEntities()
                .With<ResolutionComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Select(w => w.Get<ResolutionComponent>().Value)
                .Last();
        }
    }
}