namespace BeVelS.ECS.Components.Guids.Structs
{
    using System;

    public struct CollectionGuidComponent
    {
        public CollectionGuidComponent(
            Guid value)
        {
            this.Value = value;
        }

        public Guid Value { get; }
    }
}