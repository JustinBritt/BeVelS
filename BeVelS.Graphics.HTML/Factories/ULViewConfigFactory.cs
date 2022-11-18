namespace BeVelS.Graphics.HTML.Factories
{
    using System;

    using log4net;

    using UltralightNet;

    using BeVelS.Graphics.HTML.InterfacesFactories;

    internal sealed class ULViewConfigFactory : IULViewConfigFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ULViewConfigFactory()
        {
        }

        public ULViewConfig Create(
            bool isAccelerated,
            bool isTransparent)
        {
            ULViewConfig ULViewConfig = default;

            try
            {
                ULViewConfig = new ULViewConfig();

                ULViewConfig.IsAccelerated = isAccelerated;

                ULViewConfig.IsTransparent = isTransparent;
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return ULViewConfig;
        }
    }
}