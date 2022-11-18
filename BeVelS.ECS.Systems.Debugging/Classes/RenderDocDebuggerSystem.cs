namespace BeVelS.ECS.Systems.Debugging.Classes
{
    using DefaultEcs;

    using BeVelS.ECS.Components.Debugging.Extensions;
    using BeVelS.ECS.Components.Debugging.Structs;
    using BeVelS.ECS.Messages.Debugging.Structs;
    using BeVelS.ECS.Systems.Debugging.Interfaces;

    using BeVelS.Graphics.Debugging.Interfaces;
    using BeVelS.Graphics.Debugging.InterfacesFactories;

    internal sealed class RenderDocDebuggerSystem : IRenderDocDebuggerSystem
    {
        public RenderDocDebuggerSystem(
            IRenderDocDebuggerFactory RenderDocDebuggerFactory,
            World world)
        {
            this.World = world;

            this.World.Subscribe(
                this);

            this.RenderDocDebugger = RenderDocDebuggerFactory.Create();

            Entity RenderDocDebuggerEntity = this.World.CreateEntity();

            RenderDocDebuggerComponent RenderDocDebuggerComponent = default;

            RenderDocDebuggerComponent.Value = this.RenderDocDebugger;

            RenderDocDebuggerEntity.Set<RenderDocDebuggerComponent>(
                RenderDocDebuggerComponent);
        }

        public bool IsEnabled { get; set; }

        public IRenderDocDebugger RenderDocDebugger { get; private set; }

        private World World { get; }

        [Subscribe]
        private void On(
            in RenderDocEndFrameCaptureMessage RenderDocEndFrameCaptureMessage)
        {
            this.RenderDocDebugger.GetRenderDoc().EndFrameCapture();
        }

        [Subscribe]
        private void On(
            in RenderDocLaunchReplayUIMessage RenderDocLaunchReplayUIMessage)
        {
            this.RenderDocDebugger.GetRenderDoc().LaunchReplayUI();
        }

        [Subscribe]
        private void On(
            in RenderDocStartFrameCaptureMessage RenderDocStartFrameCaptureMessage)
        {
            this.RenderDocDebugger.GetRenderDoc().StartFrameCapture();
        }

        public void Update(
            float state)
        {
            ref RenderDocDebuggerComponent RenderDocDebuggerComponent = ref this.World.GetRenderDocDebuggerComponentLastRef();

            RenderDocDebuggerComponent.Value = this.RenderDocDebugger;
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