namespace BeVelS.ECS.Components.Guids.InterfacesFactories
{
    using System;

    using BeVelS.ECS.Components.Guids.Structs;

    public interface ICollectionGuidComponentFactory
    {
        CollectionGuidComponent Create(
            Guid value);
    }
}