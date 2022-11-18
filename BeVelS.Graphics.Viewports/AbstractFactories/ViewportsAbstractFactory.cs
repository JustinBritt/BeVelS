namespace BeVelS.Graphics.Viewports.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Graphics.Viewports.Factories;
    using BeVelS.Graphics.Viewports.InterfacesAbstractFactories;
    using BeVelS.Graphics.Viewports.InterfacesFactories;

    public sealed class ViewportsAbstractFactory : IViewportsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ViewportsAbstractFactory()
        {
        }

        public IViewportFactory CreateViewportFactory()
        {
            IViewportFactory factory = null;

            try
            {
                factory = new ViewportFactory();
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