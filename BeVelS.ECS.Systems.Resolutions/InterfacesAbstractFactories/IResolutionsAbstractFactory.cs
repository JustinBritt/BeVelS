namespace BeVelS.ECS.Systems.Resolutions.InterfacesAbstractFactories
{
    using BeVelS.ECS.Systems.Resolutions.InterfacesFactories;

    public interface IResolutionsAbstractFactory
    {
        IResolutionSystemFactory CreateResolutionSystemFactory();
    }
}