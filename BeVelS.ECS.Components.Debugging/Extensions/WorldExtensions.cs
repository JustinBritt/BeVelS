namespace BeVelS.ECS.Components.Debugging.Extensions
{
    using System.Linq;

    using DefaultEcs;

    using BeVelS.ECS.Components.Debugging.Structs;

    using BeVelS.Graphics.Debugging.Interfaces;

    public static class WorldExtensions
    {
        public static ref RenderDocDebuggerComponent GetRenderDocDebuggerComponentLastRef(
            this World world)
        {
            return ref world
                .GetEntities()
                .With<RenderDocDebuggerComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Last()
                .Get<RenderDocDebuggerComponent>();
        }

        public static IRenderDocDebugger GetRenderDocDebuggerLast(
            this World world)
        {
            return world
                .GetEntities()
                .With<RenderDocDebuggerComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Select(w => w.Get<RenderDocDebuggerComponent>().Value)
                .Last();
        }
    }
}