namespace BeVelS.Graphics.HTML.Interfaces.Batches
{
    using BepuUtilities.Collections;
    using BepuUtilities.Memory;

    using BeVelS.Graphics.HTML.Interfaces.Batches;
    using BeVelS.Graphics.HTML.Structs;

    public interface IHTMLBatch
    {
        void AllocateInstance(
            HTMLInstance HTMLInstance,
            BufferPool pool);

        void CreateInstances(
            int size,
            BufferPool pool);

        void DisposeInstances(
            BufferPool pool);

        ref QuickList<HTMLInstance> GetInstances();
    }
}