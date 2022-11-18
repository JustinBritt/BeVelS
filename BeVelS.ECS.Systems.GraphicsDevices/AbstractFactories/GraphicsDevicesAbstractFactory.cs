namespace BeVelS.ECS.Systems.GraphicsDevices.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Systems.GraphicsDevices.Factories;
    using BeVelS.ECS.Systems.GraphicsDevices.InterfacesAbstractFactories;
    using BeVelS.ECS.Systems.GraphicsDevices.InterfacesFactories;

    public sealed class GraphicsDevicesAbstractFactory : IGraphicsDevicesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public GraphicsDevicesAbstractFactory()
        {
        }

        public IGraphicsDeviceSystemFactory CreateGraphicsDeviceSystemFactory()
        {
            IGraphicsDeviceSystemFactory factory = null;

            try
            {
                factory = new GraphicsDeviceSystemFactory();
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