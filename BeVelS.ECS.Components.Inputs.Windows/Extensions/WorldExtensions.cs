namespace BeVelS.ECS.Components.Inputs.Windows.Extensions
{
    using System.Linq;

    using DefaultEcs;

    using BeVelS.ECS.Components.Inputs.Windows.Structs;

    using BeVelS.Integration.Windows.Interfaces.Inputs;

    public static class WorldExtensions
    {
        public static ref Win32InputComponent GetWin32InputComponentLastRef(
            this World world)
        {
            return ref world
                .GetEntities()
                .With<Win32InputComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Last()
                .Get<Win32InputComponent>();
        }

        public static IWin32Input GetWin32InputLast(
            this World world)
        {
            return world
                .GetEntities()
                .With<Win32InputComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Select(w => w.Get<Win32InputComponent>().Value)
                .Last();
        }
    }
}