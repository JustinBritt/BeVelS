namespace BeVelS.ECS.Systems.RenderSurfaces.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Systems.RenderSurfaces.Factories;
    using BeVelS.ECS.Systems.RenderSurfaces.InterfacesAbstractFactories;
    using BeVelS.ECS.Systems.RenderSurfaces.InterfacesFactories;

    public sealed class RenderSurfacesAbstractFactory : IRenderSurfacesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RenderSurfacesAbstractFactory()
        {
        }

        public IRenderSurfaceSystemFactory CreateRenderSurfaceSystemFactory()
        {
            IRenderSurfaceSystemFactory factory = null;

            try
            {
                factory = new RenderSurfaceSystemFactory();
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