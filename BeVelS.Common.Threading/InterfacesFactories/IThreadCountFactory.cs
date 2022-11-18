namespace BeVelS.Common.Threading.InterfacesFactories
{
    using BeVelS.Common.Threading.Interfaces;

    public interface IThreadCountFactory
    {
        IThreadCount Create(
            int value);
    }
}