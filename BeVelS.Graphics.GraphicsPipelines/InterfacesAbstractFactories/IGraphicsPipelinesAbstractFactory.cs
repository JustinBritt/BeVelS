namespace BeVelS.Graphics.GraphicsPipelines.InterfacesAbstractFactories
{
    using BeVelS.Graphics.GraphicsPipelines.InterfacesFactories;
    using BeVelS.Graphics.GraphicsPipelines.InterfacesFactories.Descriptions;

    public interface IGraphicsPipelinesAbstractFactory
    {
        IBackgroundGraphicsPipelineFactory CreateBackgroundGraphicsPipelineFactory();

        IBoxGraphicsPipelineFactory CreateBoxGraphicsPipelineFactory();

        ICapsuleGraphicsPipelineFactory CreateCapsuleGraphicsPipelineFactory();

        ICylinderGraphicsPipelineFactory CreateCylinderGraphicsPipelineFactory();

        IGlyphGraphicsPipelineFactory CreateGlyphGraphicsPipelineFactory();

        IGraphicsPipelineDescriptionFactory CreateGraphicsPipelineDescriptionFactory();

        IHTMLGraphicsPipelineFactory CreateHTMLGraphicsPipelineFactory();

        IImageGraphicsPipelineFactory CreateImageGraphicsPipelineFactory();

        ILineGraphicsPipelineFactory CreateLineGraphicsPipelineFactory();

        IMeshGraphicsPipelineFactory CreateMeshGraphicsPipelineFactory();

        ISphereGraphicsPipelineFactory CreateSphereGraphicsPipelineFactory();

        ITriangleGraphicsPipelineFactory CreateTriangleGraphicsPipelineFactory();

        IUILineGraphicsPipelineFactory CreateUILineGraphicsPipelineFactory();
    }
}