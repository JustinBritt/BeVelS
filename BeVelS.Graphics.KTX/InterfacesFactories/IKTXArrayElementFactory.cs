namespace BeVelS.Graphics.KTX.InterfacesFactories
{
    using BeVelS.Graphics.KTX.Interfaces;

    public interface IKTXArrayElementFactory
    {
        IKTXArrayElement Create(
            IKTXFace[] faces);
    }
}