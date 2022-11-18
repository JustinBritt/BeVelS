namespace BeVelS.Graphics.KTX.InterfacesFactories
{
    using BeVelS.Graphics.KTX.Interfaces;

    public interface IKTXFaceFactory
    {
        IKTXFace Create(
            byte[] data);
    }
}