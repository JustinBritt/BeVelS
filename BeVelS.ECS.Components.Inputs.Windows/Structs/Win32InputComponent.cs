namespace BeVelS.ECS.Components.Inputs.Windows.Structs
{
    using BeVelS.Integration.Windows.Interfaces.Inputs;

    public struct Win32InputComponent
    {
        public Win32InputComponent(
            IWin32Input value)
        {
            this.Value = value;
        }

        public IWin32Input Value { get; set; }
    }
}