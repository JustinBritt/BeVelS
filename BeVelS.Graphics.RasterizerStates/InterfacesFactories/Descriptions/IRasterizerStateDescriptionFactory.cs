namespace BeVelS.Graphics.RasterizerStates.InterfacesFactories.Descriptions
{
    using Veldrid;

    public interface IRasterizerStateDescriptionFactory
    {
        RasterizerStateDescription Create(
            FaceCullMode cullMode,
            PolygonFillMode fillMode,
            FrontFace frontFace,
            bool depthClipEnabled,
            bool scissorTestEnabled);

        RasterizerStateDescription CreateD3D11Default();
    }
}