namespace BeVelS.Graphics.Fonts.Factories
{
    using System;

    using log4net;

    using BeVelS.Graphics.Fonts.Classes;
    using BeVelS.Graphics.Fonts.Interfaces;
    using BeVelS.Graphics.Fonts.InterfacesFactories;

    internal sealed class FontPackerFactory : IFontPackerFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FontPackerFactory()
        {
        }

        public IFontPacker Create(
            int width,
            int mipLevels,
            int padding,
            int characterCount)
        {
            IFontPacker fontPacker = null;

            try
            {
                fontPacker = new FontPacker(
                    width: width,
                    mipLevels: mipLevels,
                    padding: padding,
                    characterCount: characterCount);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return fontPacker;
        }
    }
}