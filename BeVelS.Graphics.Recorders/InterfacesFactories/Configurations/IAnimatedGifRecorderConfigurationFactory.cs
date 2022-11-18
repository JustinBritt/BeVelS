namespace BeVelS.Graphics.Recorders.InterfacesFactories.Configurations
{
    using BeVelS.Graphics.Recorders.Interfaces.Configurations;

    public interface IAnimatedGifRecorderConfigurationFactory
    {
        IAnimatedGifRecorderConfiguration Create(
            string outputDirectory);
    }
}