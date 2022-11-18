namespace BeVelS.Graphics.HTML.InterfacesFactories
{
    using UltralightNet;

    public interface IULConfigFactory
    {
        ULConfig Create(
            uint bitmapAlignment,
            ULFaceWinding faceWinding,
            bool forceRepaint);
    }
}