namespace BeVelS.Graphics.ResourceLayouts.InterfacesFactories.Descriptions
{
    using Veldrid;

    public interface IResourceLayoutElementDescriptionFactory
    {
        ResourceLayoutElementDescription Create(
            string name,
            ResourceKind kind,
            ShaderStages stages);

        ResourceLayoutElementDescription Create(
            string name,
            ResourceKind kind,
            ShaderStages stages,
            ResourceLayoutElementOptions options);
    }
}