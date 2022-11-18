namespace BeVelS.ECS.Components.Fonts.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Components.Fonts.Factories;
    using BeVelS.ECS.Components.Fonts.InterfacesAbstractFactories;
    using BeVelS.ECS.Components.Fonts.InterfacesFactories;

    public sealed class FontsAbstractFactory : IFontsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FontsAbstractFactory()
        {
        }

        public IFontComponentFactory CreateFontComponentFactory()
        {
            IFontComponentFactory factory = null;

            try
            {
                factory = new FontComponentFactory();
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