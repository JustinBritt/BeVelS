namespace BeVelS.Graphics.Images.Classes.Batches
{
    using BepuUtilities.Collections;
    using BepuUtilities.Memory;

    using BeVelS.Graphics.Images.Interfaces.Batches;
    using BeVelS.Graphics.Images.Structs;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/UI/ImageBatcher.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Added methods for allocating, creating, disposing, and getting instances.")]
    internal sealed class ImageBatch : IImageBatch
    {
        QuickList<ImageInstance> instances;

        public void AllocateInstance(
            ImageInstance imageInstance,
            BufferPool pool)
        {
            this.instances.Allocate(pool) = imageInstance;
        }

        public void CreateInstances(
            int size,
            BufferPool pool)
        {
            this.instances = new QuickList<ImageInstance>(
                size,
                pool);
        }

        public void DisposeInstances(
            BufferPool pool)
        {
            this.instances.Dispose(
                pool);
        }

        public ref QuickList<ImageInstance> GetInstances()
        {
            return ref this.instances;
        }
    }
}