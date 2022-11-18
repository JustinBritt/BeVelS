namespace BeVelS.Dependencies.AssimpNet.InterfacesAbstractFactories
{ 
    using BeVelS.Dependencies.AssimpNet.InterfacesFactories;

    public interface IAssimpNetAbstractFactory
    {
        IAssimpContextFactory CreateAssimpContextFactory();
    }
}