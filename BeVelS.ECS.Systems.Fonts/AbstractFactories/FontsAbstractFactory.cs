namespace BeVelS.ECS.Systems.Fonts.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Systems.Fonts.Factories;
    using BeVelS.ECS.Systems.Fonts.InterfacesAbstractFactories;
    using BeVelS.ECS.Systems.Fonts.InterfacesFactories;

    public sealed class FontsAbstractFactory : IFontsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FontsAbstractFactory()
        {
        }

        public IFontSystemFactory CreateFontSystemFactory()
        {
            IFontSystemFactory factory = null;

            try
            {
                factory = new FontSystemFactory();
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