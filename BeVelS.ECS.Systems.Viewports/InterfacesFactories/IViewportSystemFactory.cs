namespace BeVelS.ECS.Systems.Viewports.InterfacesFactories
{
    using DefaultEcs;

    using BeVelS.ECS.Systems.Viewports.Interfaces;

    using BeVelS.Graphics.Viewports.InterfacesFactories;

    public interface IViewportSystemFactory
    {
        IViewportSystem Create(
            IViewportFactory viewportFactory,
            World world);
    }
}