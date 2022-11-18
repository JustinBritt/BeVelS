namespace BeVelS.Physics.Constraints.Interfaces
{
    using System.Numerics;

    using BepuPhysics;

    using BepuUtilities.Collections;

    using BeVelS.Physics.Constraints.Structs.Lines;

    public unsafe interface IConstraintLineExtractor<TPrestep>
    {
        int LinesPerConstraint { get; }

        void ExtractLines(
            ref TPrestep prestepBundle,
            int setIndex,
            int * bodyLocations,
            Bodies bodies,
            ref Vector3 tint,
            ref QuickList<LineInstance> lines);
    }
}