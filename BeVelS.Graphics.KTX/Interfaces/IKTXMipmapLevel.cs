namespace BeVelS.Graphics.KTX.Interfaces
{
    public interface IKTXMipmapLevel
    {
        uint Width { get; }

        uint Height { get; }

        uint Depth { get; }

        uint TotalSize { get; }

        uint ArrayElementSize { get; }

        IKTXArrayElement[] ArrayElements { get; }
    }
}