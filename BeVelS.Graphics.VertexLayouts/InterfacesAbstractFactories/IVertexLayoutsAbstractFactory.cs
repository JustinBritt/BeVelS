namespace BeVelS.Graphics.VertexLayouts.InterfacesAbstractFactories
{
    using BeVelS.Graphics.VertexLayouts.InterfacesFactories.Descriptions;

    public interface IVertexLayoutsAbstractFactory
    {
        IVertexElementDescriptionFactory CreateVertexElementDescriptionFactory();

        IVertexLayoutDescriptionFactory CreateVertexLayoutDescriptionFactory();
    }
}