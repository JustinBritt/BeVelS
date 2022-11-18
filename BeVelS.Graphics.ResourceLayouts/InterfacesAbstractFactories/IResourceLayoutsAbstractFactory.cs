namespace BeVelS.Graphics.ResourceLayouts.InterfacesAbstractFactories
{
    using BeVelS.Graphics.ResourceLayouts.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.ResourceLayouts.InterfacesFactories.FragmentResourceLayouts;
    using BeVelS.Graphics.ResourceLayouts.InterfacesFactories.ResourceLayouts;
    using BeVelS.Graphics.ResourceLayouts.InterfacesFactories.VertexResourceLayouts;

    public interface IResourceLayoutsAbstractFactory
    {
        IBackgroundVertexResourceLayoutFactory CreateBackgroundVertexResourceLayoutFactory();

        IBoxFragmentResourceLayoutFactory CreateBoxFragmentResourceLayoutFactory();

        IBoxVertexResourceLayoutFactory CreateBoxVertexResourceLayoutFactory();

        ICapsuleFragmentResourceLayoutFactory CreateCapsuleFragmentResourceLayoutFactory();

        ICapsuleVertexResourceLayoutFactory CreateCapsuleVertexResourceLayoutFactory();

        ICylinderFragmentResourceLayoutFactory CreateCylinderFragmentResourceLayoutFactory();

        ICylinderVertexResourceLayoutFactory CreateCylinderVertexResourceLayoutFactory();

        IGlyphResourceLayoutFactory CreateGlyphResourceLayoutFactory();

        IHTMLResourceLayoutFactory CreateHTMLResourceLayoutFactory();

        IImageResourceLayoutFactory CreateImageResourceLayoutFactory();

        ILineVertexResourceLayoutFactory CreateLineVertexResourceLayoutFactory();

        IMeshFragmentResourceLayoutFactory CreateMeshFragmentResourceLayoutFactory();

        IMeshVertexResourceLayoutFactory CreateMeshVertexResourceLayoutFactory();

        IResourceLayoutDescriptionFactory CreateResourceLayoutDescriptionFactory();

        IResourceLayoutElementDescriptionFactory CreateResourceLayoutElementDescriptionFactory();

        ISphereFragmentResourceLayoutFactory CreateSphereFragmentResourceLayoutFactory();

        ISphereVertexResourceLayoutFactory CreateSphereVertexResourceLayoutFactory();

        ITriangleFragmentResourceLayoutFactory CreateTriangleFragmentResourceLayoutFactory();

        ITriangleVertexResourceLayoutFactory CreateTriangleVertexResourceLayoutFactory();

        IUILineVertexResourceLayoutFactory CreateUILineVertexResourceLayoutFactory();
    }
}