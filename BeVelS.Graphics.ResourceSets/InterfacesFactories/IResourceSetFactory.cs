namespace BeVelS.Graphics.ResourceSets.InterfacesFactories
{
    using Veldrid;

    using BeVelS.Graphics.ResourceSets.InterfacesFactories.Descriptions;

    public interface IResourceSetFactory
    {
        ResourceSet Create(
            IResourceSetDescriptionFactory resourceSetDescriptionFactory,
            GraphicsDevice graphicsDevice,
            ResourceLayout resourceLayout,
            params BindableResource[] bindableResource);
    }
}