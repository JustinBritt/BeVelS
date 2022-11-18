namespace BeVelS.Graphics.Viewports.InterfacesAbstractFactories
{
    using BeVelS.Graphics.Viewports.InterfacesFactories;

    public interface IViewportsAbstractFactory
    {
        IViewportFactory CreateViewportFactory();
    }
}