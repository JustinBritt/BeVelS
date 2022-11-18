namespace BeVelS.Graphics.Meshes.InterfacesAbstractFactories
{
    using BeVelS.Graphics.Meshes.InterfacesFactories;

    public interface IMeshesAbstractFactory
    {
        IMeshCacheFactory CreateMeshCacheFactory();
    }
}