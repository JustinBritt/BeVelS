namespace BeVelS.Graphics.BlendStates.Factories.Descriptions
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.BlendStates.InterfacesFactories.Descriptions;

    internal sealed class BlendStateDescriptionFactory : IBlendStateDescriptionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BlendStateDescriptionFactory()
        {
        }

        public BlendStateDescription Create(
            RgbaFloat blendFactor,
            params BlendAttachmentDescription[] attachmentStates)
        {
            BlendStateDescription blendStateDescription = default;

            try
            {
                blendStateDescription = new BlendStateDescription(
                    blendFactor,
                    attachmentStates);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return blendStateDescription;
        }

        public BlendStateDescription Create(
            RgbaFloat blendFactor,
            bool alphaToCoverageEnabled,
            params BlendAttachmentDescription[] attachmentStates)
        {
            BlendStateDescription blendStateDescription = default;

            try
            {
                blendStateDescription = new BlendStateDescription(
                    blendFactor,
                    alphaToCoverageEnabled,
                    attachmentStates);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return blendStateDescription;
        }

        // https://docs.microsoft.com/en-us/windows/win32/api/d3d11/ns-d3d11-d3d11_blend_desc
        public BlendStateDescription CreateD3D11Default(
            IBlendAttachmentDescriptionFactory blendAttachmentDescriptionFactory,
            RgbaFloat blendFactor)
        {
            BlendStateDescription blendStateDescription = default;

            try
            {
                blendStateDescription = new BlendStateDescription(
                    blendFactor: blendFactor,
                    alphaToCoverageEnabled: false,
                    attachmentStates: blendAttachmentDescriptionFactory.Create(
                        blendEnabled: false,
                        sourceColorFactor: BlendFactor.One,
                        destinationColorFactor: BlendFactor.Zero,
                        colorFunction: BlendFunction.Add,
                        sourceAlphaFactor: BlendFactor.One,
                        destinationAlphaFactor: BlendFactor.Zero,
                        alphaFunction: BlendFunction.Add));
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return blendStateDescription;
        }
    }
}