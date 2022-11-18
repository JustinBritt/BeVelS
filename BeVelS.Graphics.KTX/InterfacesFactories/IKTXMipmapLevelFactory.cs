namespace BeVelS.Graphics.KTX.InterfacesFactories
{
    using BeVelS.Graphics.KTX.Interfaces;

    public interface IKTXMipmapLevelFactory
    {
        IKTXMipmapLevel Create(
            uint width,
            uint height,
            uint depth,
            uint totalSize,
            uint arraySliceSize,
            IKTXArrayElement[] slices);
    }
}