namespace BeVelS.Graphics.KTX.InterfacesAbstractFactories
{
    using BeVelS.Graphics.KTX.InterfacesFactories;

    public interface IKTXAbstractFactory
    {
        IKTXArrayElementFactory CreateKTXArrayElementFactory();

        IKTXFaceFactory CreateKTXFaceFactory();

        IKTXFileFactory CreateKTXFileFactory();

        IKTXKeyValuePairFactory CreateKTXKeyValuePairFactory();

        IKTXMipmapLevelFactory CreateKTXMipmapLevelFactory();
    }
}