namespace BeVelS.ECS.Components.Hosts.Windows.Structs
{
    using BeVelS.Integration.Windows.Interfaces.Hosts;

    public struct Win32HostComponent
    {
        public Win32HostComponent(
            IWin32Host value)
        {
            this.Value = value;
        }

        public IWin32Host Value { get; set; }
    }
}