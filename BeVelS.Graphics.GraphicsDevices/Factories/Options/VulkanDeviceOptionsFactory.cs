namespace BeVelS.Graphics.GraphicsDevices.Factories.Options
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.GraphicsDevices.InterfacesFactories.Options;
    
    internal sealed class VulkanDeviceOptionsFactory : IVulkanDeviceOptionsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VulkanDeviceOptionsFactory()
        {
        }

        public VulkanDeviceOptions Create()
        {
            VulkanDeviceOptions vulkanDeviceOptions = default;

            try
            {
                vulkanDeviceOptions = new VulkanDeviceOptions();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return vulkanDeviceOptions;
        }

        public VulkanDeviceOptions Create(
            string[] instanceExtensions,
            string[] deviceExtensions)
        {
            VulkanDeviceOptions vulkanDeviceOptions = default;

            try
            {
                vulkanDeviceOptions = new VulkanDeviceOptions(
                    instanceExtensions: instanceExtensions,
                    deviceExtensions: deviceExtensions);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return vulkanDeviceOptions;
        }
    }
}