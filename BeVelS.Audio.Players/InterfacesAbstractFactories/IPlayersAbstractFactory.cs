namespace BeVelS.Audio.Players.InterfacesAbstractFactories
{
    using BeVelS.Audio.Players.InterfacesFactories;

    public interface IPlayersAbstractFactory
    {
        IWaveOutEventFactory CreateWaveOutEventFactory();
    }
}