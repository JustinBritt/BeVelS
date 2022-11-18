namespace BeVelS.Graphics.ResourceLayouts.InterfacesFactories.Descriptions
{
    using Veldrid;

    public interface IResourceLayoutDescriptionFactory
    {
        ResourceLayoutDescription Create(
            params ResourceLayoutElementDescription[] elements);
    }
}