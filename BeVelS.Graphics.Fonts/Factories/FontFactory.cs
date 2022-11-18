namespace BeVelS.Graphics.Fonts.Factories
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Graphics.Buffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Fonts.Classes;
    using BeVelS.Graphics.Fonts.Interfaces;
    using BeVelS.Graphics.Fonts.InterfacesFactories;

    internal sealed class FontFactory : IFontFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FontFactory()
        {
        }

        public IFont Create(
            IVector2Factory vector2Factory,
            IBufferDescriptionFactory bufferDescriptionFactory,
            IFontContent fontContent,
            GraphicsDevice graphicsDevice)
        {
            IFont font = null;

            try
            {
                font = new Font(
                    vector2Factory,
                    bufferDescriptionFactory,
                    graphicsDevice,
                    fontContent);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return font;
        }
    }
}