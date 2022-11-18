namespace BeVelS.ECS.Components.Guids.InterfacesAbstractFactories
{
    using BeVelS.ECS.Components.Guids.InterfacesFactories;

    public interface IGuidsAbstractFactory
    {
        ICollectionGuidComponentFactory CreateCollectionGuidComponentFactory();

        IGuidComponentFactory CreateGuidComponentFactory();
    }
}