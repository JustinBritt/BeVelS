namespace BeVelS.ECS.Components.RenderTargets.Extensions
{
    using System.Linq;

    using DefaultEcs;

    using Veldrid;

    using BeVelS.ECS.Components.RenderTargets.Structs;
    
    public static class WorldExtensions
    {
        public static ref ColorBufferComponent GetColorBufferComponentLastRef(
            this World world)
        {
            return ref world
                .GetEntities()
                .With<ColorBufferComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Last()
                .Get<ColorBufferComponent>();
        }

        public static Texture GetColorBufferLast(
            this World world)
        {
            return world
                .GetEntities()
                .With<ColorBufferComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Select(w => w.Get<ColorBufferComponent>().Value)
                .Last();
        }

        public static ref DepthBufferComponent GetDepthBufferComponentLastRef(
            this World world)
        {
            return ref world
                .GetEntities()
                .With<DepthBufferComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Last()
                .Get<DepthBufferComponent>();
        }

        public static Texture GetDepthBufferLast(
            this World world)
        {
            return world
                .GetEntities()
                .With<DepthBufferComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Select(w => w.Get<DepthBufferComponent>().Value)
                .Last();
        }

        public static ref ResolvedColorBufferComponent GetResolvedColorBufferComponentLastRef(
            this World world)
        {
            return ref world
                .GetEntities()
                .With<ResolvedColorBufferComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Last()
                .Get<ResolvedColorBufferComponent>();
        }

        public static Texture GetResolvedColorBufferLast(
            this World world)
        {
            return world
                .GetEntities()
                .With<ResolvedColorBufferComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Select(w => w.Get<ResolvedColorBufferComponent>().Value)
                .Last();
        }
    }
}