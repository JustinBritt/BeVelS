namespace BeVelS.Graphics.VertexLayouts.InterfacesFactories.Descriptions
{
    using Veldrid;

    public interface IVertexLayoutDescriptionFactory
    {
        VertexLayoutDescription Create(
            params VertexElementDescription[] elements);

        VertexLayoutDescription Create(
            uint stride,
            params VertexElementDescription[] elements);

        VertexLayoutDescription Create(
           uint stride,
           uint instanceStepRate,
           params VertexElementDescription[] elements);
    }
}