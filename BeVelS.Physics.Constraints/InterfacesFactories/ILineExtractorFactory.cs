namespace BeVelS.Physics.Constraints.InterfacesFactories
{
    using BepuUtilities.Memory;

    using BeVelS.Common.Parallelism.Interfaces;
    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Physics.Constraints.Interfaces;

    public interface ILineExtractorFactory
    {
        ILineExtractor Create(
            IVector3Factory vector3Factory,
            BufferPool bufferPool,
            IParallelLooper parallelLooper,
            int initialLineCapacity = 8192);
    }
}