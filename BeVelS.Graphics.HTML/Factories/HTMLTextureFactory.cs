namespace BeVelS.Graphics.HTML.Factories
{
    using System;

    using log4net;

    using UltralightNet;

    using BeVelS.Graphics.HTML.Classes;
    using BeVelS.Graphics.HTML.Interfaces;
    using BeVelS.Graphics.HTML.InterfacesFactories;

    internal sealed class HTMLTextureFactory : IHTMLTextureFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HTMLTextureFactory()
        {
        }

        public IHTMLTexture Create(
            ULBitmap[] ULBitmaps)
        {
            IHTMLTexture HTMLTexture = null;

            try
            {
                HTMLTexture = new HTMLTexture(
                    ULBitmaps: ULBitmaps);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return HTMLTexture;
        }
    }
}