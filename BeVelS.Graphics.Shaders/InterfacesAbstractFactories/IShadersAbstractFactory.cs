namespace BeVelS.Graphics.Shaders.InterfacesAbstractFactories
{
    using BeVelS.Graphics.Shaders.InterfacesFactories;
    using BeVelS.Graphics.Shaders.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shaders.InterfacesFactories.FragmentShaders;
    using BeVelS.Graphics.Shaders.InterfacesFactories.VertexShaders;

    public interface IShadersAbstractFactory
    {
        IBackgroundFragmentShaderFactory CreateBackgroundFragmentShaderFactory();

        IBackgroundShaderFactory CreateBackgroundShaderFactory();

        IBackgroundVertexShaderFactory CreateBackgroundVertexShaderFactory();

        IBoxFragmentShaderFactory CreateBoxFragmentShaderFactory();

        IBoxShaderFactory CreateBoxShaderFactory();

        IBoxVertexShaderFactory CreateBoxVertexShaderFactory();

        ICapsuleFragmentShaderFactory CreateCapsuleFragmentShaderFactory();

        ICapsuleShaderFactory CreateCapsuleShaderFactory();

        ICapsuleVertexShaderFactory CreateCapsuleVertexShaderFactory();

        ICylinderFragmentShaderFactory CreateCylinderFragmentShaderFactory();

        ICylinderShaderFactory CreateCylinderShaderFactory();

        ICylinderVertexShaderFactory CreateCylinderVertexShaderFactory();

        IGlyphFragmentShaderFactory CreateGlyphFragmentShaderFactory();

        IGlyphShaderFactory CreateGlyphShaderFactory();

        IGlyphVertexShaderFactory CreateGlyphVertexShaderFactory();

        IHTMLFragmentShaderFactory CreateHTMLFragmentShaderFactory();

        IHTMLShaderFactory CreateHTMLShaderFactory();

        IHTMLVertexShaderFactory CreateHTMLVertexShaderFactory();

        IImageFragmentShaderFactory CreateImageFragmentShaderFactory();

        IImageShaderFactory CreateImageShaderFactory();

        IImageVertexShaderFactory CreateImageVertexShaderFactory();

        ILineFragmentShaderFactory CreateLineFragmentShaderFactory();

        ILineShaderFactory CreateLineShaderFactory();

        ILineVertexShaderFactory CreateLineVertexShaderFactory();

        IMeshFragmentShaderFactory CreateMeshFragmentShaderFactory();

        IMeshShaderFactory CreateMeshShaderFactory();

        IMeshVertexShaderFactory CreateMeshVertexShaderFactory();

        IShaderDescriptionFactory CreateShaderDescriptionFactory();

        ISphereFragmentShaderFactory CreateSphereFragmentShaderFactory();

        ISphereShaderFactory CreateSphereShaderFactory();

        ISphereVertexShaderFactory CreateSphereVertexShaderFactory();

        ITriangleFragmentShaderFactory CreateTriangleFragmentShaderFactory();

        ITriangleShaderFactory CreateTriangleShaderFactory();

        ITriangleVertexShaderFactory CreateTriangleVertexShaderFactory();

        IUILineFragmentShaderFactory CreateUILineFragmentShaderFactory();

        IUILineShaderFactory CreateUILineShaderFactory();

        IUILineVertexShaderFactory CreateUILineVertexShaderFactory();
    }
}