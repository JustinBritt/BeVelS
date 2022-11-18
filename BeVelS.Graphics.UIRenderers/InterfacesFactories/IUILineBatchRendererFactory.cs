namespace BeVelS.Graphics.UIRenderers.InterfacesFactories
{
    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.UIRenderers.Interfaces;

    public interface IUILineBatchRendererFactory
    {
        IUILineBatchRenderer Create(
            IVector2Factory vector2Factory);
    }
}