namespace BeVelS.Graphics.ResourceLayouts.InterfacesFactories.ResourceLayouts
{
    using Veldrid;

    using BeVelS.Graphics.ResourceLayouts.InterfacesFactories.Descriptions;

    public interface IGlyphResourceLayoutFactory
    {
        ResourceLayout Create(
            IResourceLayoutDescriptionFactory resourceLayoutDescriptionFactory,
            IResourceLayoutElementDescriptionFactory resourceLayoutElementDescriptionFactory,
            GraphicsDevice graphicsDevice);
    }
}