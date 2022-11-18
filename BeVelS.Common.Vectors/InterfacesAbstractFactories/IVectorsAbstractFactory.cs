namespace BeVelS.Common.Vectors.InterfacesAbstractFactories
{
    using BeVelS.Common.Vectors.InterfacesFactories;

    public interface IVectorsAbstractFactory
    {
        IVector2Factory CreateVector2Factory();

        IVector3Factory CreateVector3Factory();

        IVector4Factory CreateVector4Factory();
    }
}