namespace BeVelS.Graphics.VertexLayouts.InterfacesFactories.Descriptions
{
    using Veldrid;

    public interface IVertexElementDescriptionFactory
    {
        VertexElementDescription Create(
            string name,
            VertexElementSemantic semantic,
            VertexElementFormat format);

        VertexElementDescription Create(
            string name,
            VertexElementFormat format,
            VertexElementSemantic semantic);

        VertexElementDescription Create(
            string name,
            VertexElementSemantic semantic,
            VertexElementFormat format,
            uint offset);
    }
}