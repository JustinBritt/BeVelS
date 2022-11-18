namespace BeVelS.ECS.Components.Fonts.Extensions
{
    using System.Linq;

    using DefaultEcs;

    using BeVelS.ECS.Components.Fonts.Structs;

    using BeVelS.Graphics.Fonts.Interfaces;

    public static class WorldExtensions
    {
        public static ref FontComponent GetFontComponentLastRef(
            this World world)
        {
            return ref world
                .GetEntities()
                .With<FontComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Last()
                .Get<FontComponent>();
        }

        public static IFont GetFontLast(
            this World world)
        {
            return world
                .GetEntities()
                .With<FontComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Select(w => w.Get<FontComponent>().Value)
                .Last();
        }
    }
}