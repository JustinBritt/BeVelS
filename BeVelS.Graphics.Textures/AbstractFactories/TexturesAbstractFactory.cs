namespace BeVelS.Graphics.Textures.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Graphics.Textures.Factories;
    using BeVelS.Graphics.Textures.InterfacesAbstractFactories;
    using BeVelS.Graphics.Textures.InterfacesFactories;

    public sealed class TexturesAbstractFactory : ITexturesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TexturesAbstractFactory()
        {
        }

        public ICubemapTextureFactory CreateCubemapTextureFactory()
        {
            ICubemapTextureFactory factory = null;

            try
            {
                factory = new CubemapTextureFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IImageSharpCubemapTextureFactory CreateImageSharpCubemapTextureFactory()
        {
            IImageSharpCubemapTextureFactory factory = null;

            try
            {
                factory = new ImageSharpCubemapTextureFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IImageSharpTextureFactory CreateImageSharpTextureFactory()
        {
            IImageSharpTextureFactory factory = null;

            try
            {
                factory = new ImageSharpTextureFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITextureContentFactory CreateTextureContentFactory()
        {
            ITextureContentFactory factory = null;

            try
            {
                factory = new TextureContentFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITextureFactory CreateTextureFactory()
        {
            ITextureFactory factory = null;

            try
            {
                factory = new TextureFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}