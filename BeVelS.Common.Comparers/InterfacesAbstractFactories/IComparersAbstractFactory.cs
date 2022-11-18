namespace BeVelS.Common.Comparers.InterfacesAbstractFactories
{
    using BeVelS.Common.Comparers.InterfacesFactories;

    public interface IComparersAbstractFactory
    {
        IGuidEqualityComparerRefFactory CreateGuidEqualityComparerRefFactory();
    }
}