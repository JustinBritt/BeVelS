namespace BeVelS.Graphics.Viewports.Factories
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.Viewports.InterfacesFactories;

    internal sealed class ViewportFactory : IViewportFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ViewportFactory()
        {
        }

        public Viewport Create(
            float height,
            float maxDepth,
            float minDepth,
            float width,
            float X,
            float Y)
        {
            Viewport viewport = default;

            try
            {
                viewport = new Viewport(
                    x: X,
                    y: Y,
                    width: width,
                    height: height,
                    minDepth: minDepth,
                    maxDepth: maxDepth);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return viewport;
        }
    }
}