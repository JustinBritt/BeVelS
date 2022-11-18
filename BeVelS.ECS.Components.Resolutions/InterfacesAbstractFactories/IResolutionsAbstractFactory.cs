namespace BeVelS.ECS.Components.Resolutions.InterfacesAbstractFactories
{
    using BeVelS.ECS.Components.Resolutions.InterfacesFactories;

    public interface IResolutionsAbstractFactory
    {
        IResolutionComponentFactory CreateResolutionComponentFactory();
    }
}