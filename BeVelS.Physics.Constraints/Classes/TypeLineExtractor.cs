namespace BeVelS.Physics.Constraints.Classes
{
    using System.Diagnostics;
    using System.Numerics;
    using System.Runtime.CompilerServices;

    using BepuPhysics;
    using BepuPhysics.Constraints;

    using BepuUtilities;
    using BepuUtilities.Collections;
    using BepuUtilities.Memory;

    using BeVelS.Licensing.Classes;

    using BeVelS.Physics.Constraints.AbstractClasses.Constraints;
    using BeVelS.Physics.Constraints.Interfaces;
    using BeVelS.Physics.Constraints.Structs.Lines;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/Constraints/ConstraintLineExtractor.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges)]
    internal sealed class TypeLineExtractor<T, TBodyReferences, TPrestep, TAccumulatedImpulses> : TypeLineExtractor
        where TBodyReferences : unmanaged
        where TPrestep : unmanaged
        where T : struct, IConstraintLineExtractor<TPrestep>
    {
        public override int LinesPerConstraint => default(T).LinesPerConstraint;

        public unsafe override void ExtractLines(
            Bodies bodies,
            int setIndex,
            ref TypeBatch typeBatch,
            int constraintStart,
            int constraintCount,
            ref QuickList<LineInstance> lines)
        {
            ref var prestepStart = ref Buffer<TPrestep>.Get(
                ref typeBatch.PrestepData,
                0);

            ref var referencesStart = ref Buffer<TBodyReferences>.Get(
                ref typeBatch.BodyReferences,
                0);
            
            // For now, we assume that TBodyReferences is always a series of contiguous Vector<int> values.
            // We can extract each body by abusing the memory layout.
            var bodyCount = Unsafe.SizeOf<TBodyReferences>() / Unsafe.SizeOf<Vector<int>>();
            
            Debug.Assert(
                bodyCount * Unsafe.SizeOf<Vector<int>>() == Unsafe.SizeOf<TBodyReferences>());
            
            var bodyIndices = stackalloc int[bodyCount];
            
            var extractor = default(T);

            var constraintEnd = constraintStart + constraintCount;
            
            if (setIndex == 0)
            {
                var tint = new Vector3(1, 1, 1);
            
                for (int i = constraintStart; i < constraintEnd; ++i)
                {
                    if (typeBatch.IndexToHandle[i].Value >= 0)
                    {
                        BundleIndexing.GetBundleIndices(
                            i,
                            out var bundleIndex,
                            out var innerIndex);
                
                        ref var prestepBundle = ref Unsafe.Add(
                            ref prestepStart,
                            bundleIndex);
                        
                        ref var referencesBundle = ref Unsafe.Add(
                            ref referencesStart,
                            bundleIndex);
                        
                        ref var firstReference = ref Unsafe.As<TBodyReferences, Vector<int>>
                            (ref referencesBundle);
                        
                        for (int j = 0; j < bodyCount; ++j)
                        {
                            // Active set constraint body references refer directly to the body index.
                            bodyIndices[j] = GatherScatter.Get(ref Unsafe.Add(ref firstReference, j), innerIndex) & Bodies.BodyReferenceMask;
                        }
                        
                        extractor.ExtractLines(
                            ref GatherScatter.GetOffsetInstance(
                                ref prestepBundle,
                                innerIndex),
                            setIndex,
                            bodyIndices,
                            bodies,
                            ref tint,
                            ref lines);
                    }
                }
            }
            else
            {
                var tint = new Vector3(0.4f, 0.4f, 0.8f);
                
                for (int i = constraintStart; i < constraintEnd; ++i)
                {
                    if (typeBatch.IndexToHandle[i].Value >= 0)
                    {
                        BundleIndexing.GetBundleIndices(
                            i,
                            out var bundleIndex,
                            out var innerIndex);
                
                        ref var prestepBundle = ref Unsafe.Add(
                            ref prestepStart,
                            bundleIndex);
                        
                        ref var referencesBundle = ref Unsafe.Add(
                            ref referencesStart,
                            bundleIndex);
                        
                        ref var firstReference = ref Unsafe.As<TBodyReferences, Vector<int>>(
                            ref referencesBundle);
                        
                        for (int j = 0; j < bodyCount; ++j)
                        {
                            // Inactive constraints store body references in the form of handles, so we have to follow the indirection.
                            var bodyHandle = GatherScatter.Get(ref Unsafe.Add(ref firstReference, j), innerIndex) & Bodies.BodyReferenceMask;
                        
                            Debug.Assert(
                                bodies.HandleToLocation[bodyHandle].SetIndex == setIndex);
                            
                            bodyIndices[j] = bodies.HandleToLocation[bodyHandle].Index & Bodies.BodyReferenceMask;
                        }
                        
                        extractor.ExtractLines(
                            ref GatherScatter.GetOffsetInstance(
                                ref prestepBundle,
                                innerIndex),
                            setIndex,
                            bodyIndices,
                            bodies,
                            ref tint,
                            ref lines);
                    }
                }
            }
        }
    }
}