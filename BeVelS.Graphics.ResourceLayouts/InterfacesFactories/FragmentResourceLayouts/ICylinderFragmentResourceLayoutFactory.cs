namespace BeVelS.Graphics.ResourceLayouts.InterfacesFactories.FragmentResourceLayouts
{
    using Veldrid;

    using BeVelS.Graphics.ResourceLayouts.InterfacesFactories.Descriptions;

    public interface ICylinderFragmentResourceLayoutFactory
    {
        ResourceLayout Create(
            IResourceLayoutDescriptionFactory resourceLayoutDescriptionFactory,
            IResourceLayoutElementDescriptionFactory resourceLayoutElementDescriptionFactory,
            GraphicsDevice graphicsDevice);
    }
}