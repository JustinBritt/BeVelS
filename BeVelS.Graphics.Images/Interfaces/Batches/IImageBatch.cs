namespace BeVelS.Graphics.Images.Interfaces.Batches
{
    using BepuUtilities.Collections;
    using BepuUtilities.Memory;

    using BeVelS.Graphics.Images.Structs;

    public interface IImageBatch
    {
        void AllocateInstance(
            ImageInstance imageInstance,
            BufferPool pool);

        void CreateInstances(
            int size,
            BufferPool pool);

        void DisposeInstances(
            BufferPool pool);

        ref QuickList<ImageInstance> GetInstances();
    }
}