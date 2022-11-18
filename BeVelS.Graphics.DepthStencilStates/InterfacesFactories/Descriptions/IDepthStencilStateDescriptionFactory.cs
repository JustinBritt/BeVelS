namespace BeVelS.Graphics.DepthStencilStates.InterfacesFactories.Descriptions
{
    using Veldrid;

    public interface IDepthStencilStateDescriptionFactory
    {
        DepthStencilStateDescription Create(
               bool depthTestEnabled,
               bool depthWriteEnabled,
               ComparisonKind comparisonKind);

        DepthStencilStateDescription Create(
            bool depthTestEnabled,
            bool depthWriteEnabled,
            ComparisonKind comparisonKind,
            bool stencilTestEnabled,
            StencilBehaviorDescription stencilFront,
            StencilBehaviorDescription stencilBack,
            byte stencilReadMask,
            byte stencilWriteMask,
            uint stencilReference);

        DepthStencilStateDescription CreateD3D11Default();
    }
}