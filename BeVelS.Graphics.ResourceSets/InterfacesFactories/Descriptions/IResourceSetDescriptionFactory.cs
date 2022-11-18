namespace BeVelS.Graphics.ResourceSets.InterfacesFactories.Descriptions
{
    using Veldrid;

    public interface IResourceSetDescriptionFactory
    {
        ResourceSetDescription Create(
            ResourceLayout layout,
            params BindableResource[] boundResources);
    }
}