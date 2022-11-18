namespace BeVelS.ECS.Components.Cameras.Structs
{
    using BeVelS.Graphics.Cameras.Interfaces;

    public struct CameraComponent
    {
        public CameraComponent(
            ICamera value)
        {
            this.Value = value;
        }

        public ICamera Value { get; set; }
    }
}