namespace BeVelS.Graphics.HTML.InterfacesFactories
{
    using UltralightNet;

    public interface IULViewConfigFactory
    {
        ULViewConfig Create(
            bool isAccelerated,
            bool isTransparent);
    }
}