namespace BeVelS.Graphics.ResourceSets.Factories
{
    using Veldrid;

    using BeVelS.Graphics.ResourceSets.InterfacesFactories;
    using BeVelS.Graphics.ResourceSets.InterfacesFactories.Descriptions;

    internal sealed class ResourceSetFactory : IResourceSetFactory
    {
        public ResourceSetFactory()
        {
        }

        public ResourceSet Create(
            IResourceSetDescriptionFactory resourceSetDescriptionFactory,
            GraphicsDevice graphicsDevice,
            ResourceLayout resourceLayout,
            params BindableResource[] bindableResource)
        {
            return
                graphicsDevice.ResourceFactory.CreateResourceSet(
                    resourceSetDescriptionFactory.Create(
                        resourceLayout,
                        bindableResource));
        }
    }
}