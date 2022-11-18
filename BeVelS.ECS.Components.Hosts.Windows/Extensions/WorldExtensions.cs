namespace BeVelS.ECS.Components.Hosts.Windows.Extensions
{
    using System.Linq;

    using DefaultEcs;

    using BeVelS.ECS.Components.Hosts.Windows.Structs;

    using BeVelS.Integration.Windows.Interfaces.Hosts;

    public static class WorldExtensions
    {
        public static ref Win32HostComponent GetWin32HostComponentLastRef(
            this World world)
        {
            return ref world
                .GetEntities()
                .With<Win32HostComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Last()
                .Get<Win32HostComponent>();
        }

        public static IWin32Host GetWin32HostLast(
            this World world)
        {
            return world
                .GetEntities()
                .With<Win32HostComponent>()
                .AsEnumerable()
                .Where(w => w.IsEnabled() && w.IsAlive)
                .Select(w => w.Get<Win32HostComponent>().Value)
                .Last();
        }
    }
}