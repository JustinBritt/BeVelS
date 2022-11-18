namespace BeVelS.Graphics.Glyphs.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Graphics.Glyphs.Factories;
    using BeVelS.Graphics.Glyphs.InterfacesAbstractFactories;
    using BeVelS.Graphics.Glyphs.InterfacesFactories;

    public sealed class GlyphsAbstractFactory : IGlyphsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public GlyphsAbstractFactory()
        {
        }

        public IGlyphInstanceFactory CreateGlyphInstanceFactory()
        {
            IGlyphInstanceFactory factory = null;

            try
            {
                factory = new GlyphInstanceFactory();
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