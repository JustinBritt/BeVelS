namespace BeVelS.Physics.Constraints.Interfaces
{
    using System;

    using BepuUtilities.Collections;

    using BepuPhysics;
    using BepuPhysics.CollisionDetection;

    using BepuUtilities;

    using BeVelS.Physics.Constraints.Structs.Lines;

    public interface ILineExtractor : IDisposable
    {
        ref LineInstance Allocate();

        ref LineInstance Allocate(
            int count);

        void ClearInstances();

        void Extract(
            Simulation simulation,
            IThreadDispatcher threadDispatcher = null);

        QuickList<LineInstance> GetLines();
    }
}