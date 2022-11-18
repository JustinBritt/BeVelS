namespace BeVelS.ECS.Systems.Viewports.InterfacesAbstractFactories
{
    using BeVelS.ECS.Systems.Viewports.InterfacesFactories;

    public interface IViewportsAbstractFactory
    {
        IViewportSystemFactory CreateViewportSystemFactory();
    }
}