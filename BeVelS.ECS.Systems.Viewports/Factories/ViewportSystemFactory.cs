namespace BeVelS.ECS.Systems.Viewports.Factories
{
    using System;

    using log4net;

    using DefaultEcs;

    using BeVelS.ECS.Systems.Viewports.Classes;
    using BeVelS.ECS.Systems.Viewports.Interfaces;
    using BeVelS.ECS.Systems.Viewports.InterfacesFactories;

    using BeVelS.Graphics.Viewports.InterfacesFactories;
    
    internal sealed class ViewportSystemFactory : IViewportSystemFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ViewportSystemFactory()
        {
        }

        public IViewportSystem Create(
            IViewportFactory viewportFactory,
            World world)
        {
            IViewportSystem system = null;

            try
            {
                system = new ViewportSystem(
                    viewportFactory,
                    world);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return system;
        }
    }
}