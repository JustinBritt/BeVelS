namespace BeVelS.Graphics.BlendStates.InterfacesFactories.Descriptions
{
    using Veldrid;

    public interface IBlendAttachmentDescriptionFactory
    {
        BlendAttachmentDescription Create(
            bool blendEnabled,
            BlendFactor sourceColorFactor,
            BlendFactor destinationColorFactor,
            BlendFunction colorFunction,
            BlendFactor sourceAlphaFactor,
            BlendFactor destinationAlphaFactor,
            BlendFunction alphaFunction);
    }
}