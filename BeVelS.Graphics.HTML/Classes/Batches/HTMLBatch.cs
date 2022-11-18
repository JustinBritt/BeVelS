namespace BeVelS.Graphics.HTML.Classes.Batches
{
    using BepuUtilities.Collections;
    using BepuUtilities.Memory;

    using BeVelS.Graphics.HTML.Interfaces.Batches;
    using BeVelS.Graphics.HTML.Structs;

    internal sealed class HTMLBatch : IHTMLBatch
    {
        QuickList<HTMLInstance> instances;

        public HTMLBatch()
        {
        }

        public void AllocateInstance(
            HTMLInstance HTMLInstance,
            BufferPool pool)
        {
            this.instances.Allocate(pool) = HTMLInstance;
        }

        public void CreateInstances(
            int size,
            BufferPool pool)
        {
            this.instances = new QuickList<HTMLInstance>(
                size,
                pool);
        }

        public void DisposeInstances(
            BufferPool pool)
        {
            this.instances.Dispose(
                pool);
        }

        public ref QuickList<HTMLInstance> GetInstances()
        {
            return ref this.instances;
        }
    }
}