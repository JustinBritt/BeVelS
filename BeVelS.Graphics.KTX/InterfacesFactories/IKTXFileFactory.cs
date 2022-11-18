namespace BeVelS.Graphics.KTX.InterfacesFactories
{
    using BeVelS.Graphics.KTX.Interfaces;
    using BeVelS.Graphics.KTX.Structs;

    public interface IKTXFileFactory
    {
        IKTXFile Create(
            KTXHeader header,
            IKTXKeyValuePair[] keyValuePairs,
            IKTXMipmapLevel[] mipmaps);
    }
}