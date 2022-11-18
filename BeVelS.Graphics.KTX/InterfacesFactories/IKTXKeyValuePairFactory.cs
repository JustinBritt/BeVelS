namespace BeVelS.Graphics.KTX.InterfacesFactories
{
    using BeVelS.Graphics.KTX.Interfaces;

    public interface IKTXKeyValuePairFactory
    {
        IKTXKeyValuePair Create(
            string key,
            byte[] value);
    }
}