namespace BeVelS.ECS.Systems.Cameras.Classes
{
    using BepuUtilities;

    using DefaultEcs;

    using BeVelS.ECS.Components.Cameras.Extensions;
    using BeVelS.ECS.Components.Cameras.Structs;
    using BeVelS.ECS.Messages.Cameras.Structs;
    using BeVelS.ECS.Systems.Cameras.Interfaces;

    using BeVelS.Graphics.Cameras.Interfaces;

    internal sealed class CameraSystem : ICameraSystem
    {
        public CameraSystem(
            ICamera camera,
            World world)
        {
            this.World = world;

            this.World.Subscribe(
                this);

            this.Camera = camera;

            Entity cameraEntity = this.World.CreateEntity();

            CameraComponent cameraComponent = default;

            cameraComponent.Value = this.Camera;

            cameraEntity.Set<CameraComponent>(
                cameraComponent);
        }

        public ICamera Camera { get; private set; }

        public bool IsEnabled { get; set; }

        private World World { get; }

        [Subscribe]
        private void On(
            in CameraSetPositionMessage cameraSetPositionMessage)
        {
            this.Camera.Position = cameraSetPositionMessage.Value;

            ref CameraComponent cameraComponent = ref this.World.GetCameraComponentLastRef();

            cameraComponent.Value = this.Camera;
        }

        public void OnResize(
            Int2 resolution)
        {
            this.Camera.AspectRatio = resolution.X / (float)resolution.Y;

            ref CameraComponent cameraComponent = ref this.World.GetCameraComponentLastRef();

            cameraComponent.Value = this.Camera;
        }

        public void Update(
            float state)
        {
            if (this.IsEnabled)
            {
                ref CameraComponent cameraComponent = ref this.World.GetCameraComponentLastRef();

                cameraComponent.Value = this.Camera;
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