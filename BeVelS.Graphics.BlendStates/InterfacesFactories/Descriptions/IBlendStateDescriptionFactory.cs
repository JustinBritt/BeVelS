namespace BeVelS.Graphics.BlendStates.InterfacesFactories.Descriptions
{
    using Veldrid;

    public interface IBlendStateDescriptionFactory
    {
        BlendStateDescription Create(
            RgbaFloat blendFactor,
            params BlendAttachmentDescription[] attachmentStates);

        BlendStateDescription Create(
            RgbaFloat blendFactor,
            bool alphaToCoverageEnabled,
            params BlendAttachmentDescription[] attachmentStates);

        BlendStateDescription CreateD3D11Default(
            IBlendAttachmentDescriptionFactory blendAttachmentDescriptionFactory,
            RgbaFloat blendFactor);
    }
}