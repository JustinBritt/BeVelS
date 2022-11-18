namespace BeVelS.Graphics.Samplers.InterfacesFactories.Descriptions
{
    using Veldrid;

    public interface ISamplerDescriptionFactory
    {
        SamplerDescription Create();

        SamplerDescription Create(
            SamplerAddressMode addressModeU,
            SamplerAddressMode addressModeV,
            SamplerAddressMode addressModeW,
            SamplerFilter filter,
            ComparisonKind? comparisonKind,
            uint maximumAnisotropy,
            uint minimumLod,
            uint maximumLod,
            int lodBias,
            SamplerBorderColor borderColor);

        SamplerDescription CreateD3D11Default();
    }
}