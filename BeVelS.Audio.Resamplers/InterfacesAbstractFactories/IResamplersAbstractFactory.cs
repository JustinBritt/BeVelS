namespace BeVelS.Audio.Resamplers.InterfacesAbstractFactories
{
    using BeVelS.Audio.Resamplers.InterfacesFactories;

    public interface IResamplersAbstractFactory
    {
        IWdlResamplingSampleProviderFactory CreateWdlResamplingSampleProviderFactory();
    }
}