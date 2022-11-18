namespace BeVelS.Graphics.Samplers.Factories.Descriptions
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.Samplers.InterfacesFactories.Descriptions;

    internal sealed class SamplerDescriptionFactory : ISamplerDescriptionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SamplerDescriptionFactory()
        {
        }

        public SamplerDescription Create()
        {
            SamplerDescription samplerDescription = default;

            try
            {
                samplerDescription = new SamplerDescription();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return samplerDescription;
        }

        public SamplerDescription Create(
            SamplerAddressMode addressModeU,
            SamplerAddressMode addressModeV,
            SamplerAddressMode addressModeW,
            SamplerFilter filter,
            ComparisonKind? comparisonKind,
            uint maximumAnisotropy,
            uint minimumLod,
            uint maximumLod,
            int lodBias,
            SamplerBorderColor borderColor)
        {
            SamplerDescription samplerDescription = default;

            try
            {
                samplerDescription = new SamplerDescription(
                    addressModeU,
                    addressModeV,
                    addressModeW,
                    filter,
                    comparisonKind,
                    maximumAnisotropy,
                    minimumLod,
                    maximumLod,
                    lodBias,
                    borderColor);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return samplerDescription;
        }

        // https://docs.microsoft.com/en-us/windows/win32/api/d3d11/ns-d3d11-d3d11_sampler_desc
        public SamplerDescription CreateD3D11Default()
        {
            SamplerDescription samplerDescription = default;

            try
            {
                samplerDescription = new SamplerDescription(
                    SamplerAddressMode.Clamp,
                    SamplerAddressMode.Clamp,
                    SamplerAddressMode.Clamp,
                    SamplerFilter.MinLinear_MagLinear_MipLinear,
                    ComparisonKind.Never,
                    (uint)1,
                    uint.MinValue,
                    uint.MaxValue,
                    (int)0,
                    SamplerBorderColor.OpaqueWhite);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return samplerDescription;
        }
    }
}