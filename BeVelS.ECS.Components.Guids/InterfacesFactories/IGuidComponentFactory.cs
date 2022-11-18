namespace BeVelS.ECS.Components.Guids.InterfacesFactories
{
    using System;

    using BeVelS.ECS.Components.Guids.Structs;

    public interface IGuidComponentFactory
    {
        GuidComponent Create();

        GuidComponent Create(
            Guid value);
    }
}