namespace BeVelS.Graphics.HTML.Factories
{
    using System;

    using log4net;

    using BeVelS.Graphics.HTML.Classes;
    using BeVelS.Graphics.HTML.Interfaces;
    using BeVelS.Graphics.HTML.InterfacesFactories;

    internal sealed class ULBitmapRendererFactory : IULBitmapRendererFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ULBitmapRendererFactory()
        {
        }

        public IULBitmapRenderer Create()
        {
            IULBitmapRenderer ULBitmapRenderer = null;

            try
            {
                ULBitmapRenderer = new ULBitmapRenderer();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return ULBitmapRenderer;
        }
    }
}