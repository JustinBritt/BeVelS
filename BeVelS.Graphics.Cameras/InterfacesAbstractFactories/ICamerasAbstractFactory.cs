namespace BeVelS.Graphics.Cameras.InterfacesAbstractFactories
{
    using BeVelS.Graphics.Cameras.InterfacesFactories;

    public interface ICamerasAbstractFactory
    {
        ICameraFactory CreateCameraFactory();
    }
}