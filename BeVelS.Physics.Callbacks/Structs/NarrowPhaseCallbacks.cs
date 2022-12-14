namespace BeVelS.Physics.Callbacks.Structs
{
    using System.Runtime.CompilerServices;

    using BepuPhysics;
    using BepuPhysics.Collidables;
    using BepuPhysics.CollisionDetection;
    using BepuPhysics.Constraints;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/Demos/DemoCallbacks.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges)]
    public unsafe struct NarrowPhaseCallbacks : INarrowPhaseCallbacks
    {
        public SpringSettings ContactSpringiness;

        public float MaximumRecoveryVelocity;
        
        public float FrictionCoefficient;

        public NarrowPhaseCallbacks(
            SpringSettings contactSpringiness,
            float maximumRecoveryVelocity = 2f,
            float frictionCoefficient = 1f)
        {
            this.ContactSpringiness = contactSpringiness;
            
            this.MaximumRecoveryVelocity = maximumRecoveryVelocity;
            
            this.FrictionCoefficient = frictionCoefficient;
        }

        public void Initialize(
            Simulation simulation)
        {
            // Use a default if the springiness value wasn't initialized... at least until struct field initializers are supported outside of previews.
            if (ContactSpringiness.AngularFrequency == 0 && ContactSpringiness.TwiceDampingRatio == 0)
            {
                this.ContactSpringiness = new(
                    30,
                    1);
                
                this.MaximumRecoveryVelocity = 2f;
                
                this.FrictionCoefficient = 1f;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool AllowContactGeneration(
            int workerIndex,
            CollidableReference a,
            CollidableReference b,
            ref float speculativeMargin)
        {
            // While the engine won't even try creating pairs between statics at all, it will ask about kinematic-kinematic pairs.
            // Those pairs cannot emit constraints since both involved bodies have infinite inertia. Since most of the demos don't need
            // to collect information about kinematic-kinematic pairs, we'll require that at least one of the bodies needs to be dynamic.
            return a.Mobility == CollidableMobility.Dynamic || b.Mobility == CollidableMobility.Dynamic;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool AllowContactGeneration(
            int workerIndex,
            CollidablePair pair,
            int childIndexA,
            int childIndexB)
        {
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe bool ConfigureContactManifold<TManifold>(
            int workerIndex,
            CollidablePair pair,
            ref TManifold manifold,
            out PairMaterialProperties pairMaterial) 
            where TManifold : unmanaged, IContactManifold<TManifold>
        {
            pairMaterial.FrictionCoefficient = FrictionCoefficient;
            
            pairMaterial.MaximumRecoveryVelocity = MaximumRecoveryVelocity;
            
            pairMaterial.SpringSettings = ContactSpringiness;
            
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool ConfigureContactManifold(
            int workerIndex,
            CollidablePair pair,
            int childIndexA,
            int childIndexB,
            ref ConvexContactManifold manifold)
        {
            return true;
        }

        public void Dispose()
        {
        }
    }
}