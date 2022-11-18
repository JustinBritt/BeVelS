namespace BeVelS.Physics.Meshes.InterfacesAbstractFactories
{
    using BeVelS.Physics.Meshes.InterfacesFactories;

    public interface IMeshesAbstractFactory
    {
        IDeformedPlaneFactory CreateDeformedPlaneFactory();

        IFanFactory CreateFanFactory();
    }
}