namespace BeVelS.ECS.Systems.Viewports.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Systems.Viewports.Factories;
    using BeVelS.ECS.Systems.Viewports.InterfacesAbstractFactories;
    using BeVelS.ECS.Systems.Viewports.InterfacesFactories;
    
    public sealed class ViewportsAbstractFactory : IViewportsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ViewportsAbstractFactory()
        {
        }

        public IViewportSystemFactory CreateViewportSystemFactory()
        {
            IViewportSystemFactory factory = null;

            try
            {
                factory = new ViewportSystemFactory();
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