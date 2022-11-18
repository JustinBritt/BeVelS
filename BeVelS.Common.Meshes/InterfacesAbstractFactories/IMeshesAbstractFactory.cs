namespace BeVelS.Common.Meshes.InterfacesAbstractFactories
{
    using BeVelS.Common.Meshes.InterfacesFactories;

    public interface IMeshesAbstractFactory
    {
        IMeshContentFactory CreateMeshContentFactory();
    }
}