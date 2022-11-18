namespace BeVelS.Graphics.GraphicsDevices.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Graphics.GraphicsDevices.Factories;
    using BeVelS.Graphics.GraphicsDevices.Factories.Options;
    using BeVelS.Graphics.GraphicsDevices.InterfacesAbstractFactories;
    using BeVelS.Graphics.GraphicsDevices.InterfacesFactories;
    using BeVelS.Graphics.GraphicsDevices.InterfacesFactories.Options;

    public sealed class GraphicsDevicesAbstractFactory : IGraphicsDevicesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public GraphicsDevicesAbstractFactory()
        {
        }

        public IGraphicsDeviceFactory CreateGraphicsDeviceFactory()
        {
            IGraphicsDeviceFactory factory = null;

            try
            {
                factory = new GraphicsDeviceFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IGraphicsDeviceOptionsFactory CreateGraphicsDeviceOptionsFactory()
        {
            IGraphicsDeviceOptionsFactory factory = null;

            try
            {
                factory = new GraphicsDeviceOptionsFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IVulkanDeviceOptionsFactory CreateVulkanDeviceOptionsFactory()
        {
            IVulkanDeviceOptionsFactory factory = null;

            try
            {
                factory = new VulkanDeviceOptionsFactory();
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