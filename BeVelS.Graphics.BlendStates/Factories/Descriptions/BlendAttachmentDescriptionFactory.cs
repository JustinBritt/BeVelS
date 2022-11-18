namespace BeVelS.Graphics.BlendStates.Factories.Descriptions
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.BlendStates.InterfacesFactories.Descriptions;

    internal sealed class BlendAttachmentDescriptionFactory : IBlendAttachmentDescriptionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BlendAttachmentDescriptionFactory()
        {
        }

        public BlendAttachmentDescription Create(
            bool blendEnabled,
            BlendFactor sourceColorFactor,
            BlendFactor destinationColorFactor,
            BlendFunction colorFunction,
            BlendFactor sourceAlphaFactor,
            BlendFactor destinationAlphaFactor,
            BlendFunction alphaFunction)
        {
            BlendAttachmentDescription blendAttachmentDescription = default;

            try
            {
                blendAttachmentDescription = new BlendAttachmentDescription(
                    blendEnabled: blendEnabled,
                    sourceColorFactor: sourceColorFactor,
                    destinationColorFactor: destinationColorFactor,
                    colorFunction: colorFunction,
                    sourceAlphaFactor: sourceAlphaFactor,
                    destinationAlphaFactor: destinationAlphaFactor,
                    alphaFunction: alphaFunction);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return blendAttachmentDescription;
        }
    }
}