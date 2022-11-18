namespace BeVelS.Graphics.BackgroundRenderers.InterfacesAbstractFactories
{
    using BeVelS.Graphics.BackgroundRenderers.InterfacesFactories;

    public interface IBackgroundRenderersAbstractFactory
    {
        IBackgroundRendererFactory CreateBackgroundRendererFactory();
    }
}