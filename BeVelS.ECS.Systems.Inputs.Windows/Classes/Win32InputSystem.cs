namespace BeVelS.ECS.Systems.Inputs.Windows.Classes
{
    using DefaultEcs;

    using BeVelS.ECS.Components.Inputs.Windows.Extensions;
    using BeVelS.ECS.Components.Inputs.Windows.Structs;
    using BeVelS.ECS.Messages.Inputs.Windows.Structs;
    using BeVelS.ECS.Systems.Inputs.Windows.Interfaces;

    using BeVelS.Integration.Windows.Interfaces.Inputs;

    internal sealed class Win32InputSystem : IWin32InputSystem
    {
        public Win32InputSystem(
            IWin32Input win32Input,
            World world)
        {
            this.World = world;

            this.World.Subscribe(
                this);

            this.Win32Input = win32Input;

            Entity win32InputEntity = this.World.CreateEntity();

            Win32InputComponent win32InputComponent = default;

            win32InputComponent.Value = this.Win32Input;

            win32InputEntity.Set<Win32InputComponent>(
                win32InputComponent);
        }

        public bool IsEnabled { get; set; }

        public IWin32Input Win32Input { get; private set; }

        private World World { get; }

        [Subscribe]
        private void On(
            in Win32InputEndMessage message)
        {
            this.Win32Input.End();
        }

        [Subscribe]
        private void On(
            in Win32InputStartMessage message)
        {
            this.Win32Input.Start();
        }

        public void Update(
            float state)
        {
            ref Win32InputComponent win32InputComponent = ref this.World.GetWin32InputComponentLastRef();

            win32InputComponent.Value = this.Win32Input;
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                this.Win32Input.Dispose();
            }
        }
    }
}