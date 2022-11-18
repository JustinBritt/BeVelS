namespace BeVelS.ECS.Components.Guids.Structs
{
    using System;

    public struct GuidComponent
    {
        public GuidComponent()
        {
            this.Guid = Guid.NewGuid();
        }

        public GuidComponent(
            Guid guid)
        {
            this.Guid = guid;
        }

        public Guid Guid { get; }
    }
}