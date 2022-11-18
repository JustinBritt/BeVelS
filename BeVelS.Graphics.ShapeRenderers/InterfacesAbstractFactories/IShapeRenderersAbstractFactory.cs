namespace BeVelS.Graphics.ShapeRenderers.InterfacesAbstractFactories
{
    using BeVelS.Graphics.ShapeRenderers.InterfacesFactories;

    public interface IShapeRenderersAbstractFactory
    {
        IBoxRendererFactory CreateBoxRendererFactory();

        ICapsuleRendererFactory CreateCapsuleRendererFactory();

        ICylinderRendererFactory CreateCylinderRendererFactory();

        IMeshRendererFactory CreateMeshRendererFactory();

        ISphereRendererFactory CreateSphereRendererFactory();

        ITriangleRendererFactory CreateTriangleRendererFactory();
    }
}