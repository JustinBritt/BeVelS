namespace BeVelS.ECS.Components.Framebuffers.Extensions
{
    using System.Linq;

    using DefaultEcs;

    using Veldrid;
    
    using BeVelS.ECS.Components.Framebuffers.Structs;
    
    public static class WorldExtensions
    {
        public static ref ResolvedFramebufferComponent GetResolvedFramebufferComponentLastRef(
            this World world)
        {
            return ref world
                .GetEntities()
                .With<ResolvedFramebufferComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Last()
                .Get<ResolvedFramebufferComponent>();
        }

        public static Framebuffer GetResolvedFramebufferLast(
            this World world)
        {
            return world
                .GetEntities()
                .With<ResolvedFramebufferComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Select(w => w.Get<ResolvedFramebufferComponent>().Value)
                .Last();
        }
    }
}