namespace BeVelS.ECS.Systems.Hosts.Windows.Classes
{
    using DefaultEcs;

    using BeVelS.ECS.Components.Hosts.Windows.Extensions;
    using BeVelS.ECS.Components.Hosts.Windows.Structs;
    using BeVelS.ECS.Messages.Hosts.Windows.Structs;
    using BeVelS.ECS.Systems.Hosts.Windows.Interfaces;

    using BeVelS.Integration.Windows.Interfaces.Hosts;

    internal sealed class Win32HostSystem : IWin32HostSystem
    {
        public Win32HostSystem(
            IWin32Host win32Host,
            World world)
        {
            this.World = world;

            this.World.Subscribe(
                this);

            this.Win32Host = win32Host;

            Entity win32HostEntity = this.World.CreateEntity();

            Win32HostComponent win32HostComponent = default;

            win32HostComponent.Value = this.Win32Host;

            win32HostEntity.Set<Win32HostComponent>(
                win32HostComponent);
        }

        public bool IsEnabled { get; set; }

        public IWin32Host Win32Host { get; private set; }

        private World World { get; }

        [Subscribe]
        public void On(
            in Win32HostCloseMessage message)
        {
            this.Win32Host.Close();
        }

        public void Update(
            float state)
        {
            if (this.IsEnabled)
            {
                ref Win32HostComponent win32HostComponent = ref this.World.GetWin32HostComponentLastRef();

                win32HostComponent.Value = this.Win32Host;
            }
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;
            }
        }
    }
}