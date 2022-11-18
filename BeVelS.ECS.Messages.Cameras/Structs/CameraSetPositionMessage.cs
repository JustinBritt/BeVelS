namespace BeVelS.ECS.Messages.Cameras.Structs
{
    using System.Numerics;

    public struct CameraSetPositionMessage
    {
        public CameraSetPositionMessage(
            Vector3 value)
        {
            this.Value = value;
        }

        public Vector3 Value { get; }
    }
}