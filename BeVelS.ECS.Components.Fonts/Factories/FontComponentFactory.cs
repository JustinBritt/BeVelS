namespace BeVelS.ECS.Components.Fonts.Factories
{
    using System;

    using log4net;

    using BeVelS.ECS.Components.Fonts.InterfacesFactories;
    using BeVelS.ECS.Components.Fonts.Structs;

    using BeVelS.Graphics.Fonts.Interfaces;

    internal sealed class FontComponentFactory : IFontComponentFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FontComponentFactory()
        {
        }

        public FontComponent Create(
            IFont value)
        {
            FontComponent component = default;

            try
            {
                component = new FontComponent(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return component;
        }
    }
}