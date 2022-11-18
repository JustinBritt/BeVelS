namespace BeVelS.Graphics.GraphicsDevices.InterfacesFactories.Options
{
    using Veldrid;

    public interface IVulkanDeviceOptionsFactory
    {
        VulkanDeviceOptions Create();

        VulkanDeviceOptions Create(
            string[] instanceExtensions,
            string[] deviceExtensions);
    }
}