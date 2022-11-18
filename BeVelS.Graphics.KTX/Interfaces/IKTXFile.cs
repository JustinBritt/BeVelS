namespace BeVelS.Graphics.KTX.Interfaces
{
    using BeVelS.Graphics.KTX.Structs;

    public interface IKTXFile
    {
        KTXHeader Header { get; }

        IKTXKeyValuePair[] KeyValuePairs { get; }

        IKTXMipmapLevel[] Mipmaps { get; }
    }
}