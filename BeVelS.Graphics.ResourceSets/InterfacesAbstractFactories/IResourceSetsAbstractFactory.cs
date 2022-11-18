namespace BeVelS.Graphics.ResourceSets.InterfacesAbstractFactories
{
    using BeVelS.Graphics.ResourceSets.InterfacesFactories;
    using BeVelS.Graphics.ResourceSets.InterfacesFactories.Descriptions;

    public interface IResourceSetsAbstractFactory
    {
        IResourceSetDescriptionFactory CreateResourceSetDescriptionFactory();

        IResourceSetFactory CreateResourceSetFactory();
    }
}