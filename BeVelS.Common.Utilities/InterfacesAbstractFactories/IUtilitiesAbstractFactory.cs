namespace BeVelS.Common.Utilities.InterfacesAbstractFactories
{
    using BeVelS.Common.Utilities.InterfacesFactories.Memory;

    public interface IUtilitiesAbstractFactory
    {
        IBufferPoolFactory CreateBufferPoolFactory();
    }
}