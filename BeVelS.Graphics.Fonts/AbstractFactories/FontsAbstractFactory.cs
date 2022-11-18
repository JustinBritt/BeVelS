namespace BeVelS.Graphics.Fonts.AbstractFactories
{
    using System;
    using System.IO;

    using log4net;

    using BeVelS.Graphics.Fonts.Factories;
    using BeVelS.Graphics.Fonts.Factories.Batches;
    using BeVelS.Graphics.Fonts.InterfacesAbstractFactories;
    using BeVelS.Graphics.Fonts.InterfacesFactories;
    using BeVelS.Graphics.Fonts.InterfacesFactories.Batches;
    
    public sealed class FontsAbstractFactory : IFontsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FontsAbstractFactory()
        {
        }

        public IFontContentFactory CreateFontContentFactory()
        {
            IFontContentFactory factory = null;

            try
            {
                factory = new FontContentFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IFontFactory CreateFontFactory()
        {
            IFontFactory factory = null;

            try
            {
                factory = new FontFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IFontPackerFactory CreateFontPackerFactory()
        {
            IFontPackerFactory factory = null;

            try
            {
                factory = new FontPackerFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IGlyphBatchFactory CreateGlyphBatchFactory()
        {
            IGlyphBatchFactory factory = null;

            try
            {
                factory = new GlyphBatchFactory();
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