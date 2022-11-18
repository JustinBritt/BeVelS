namespace BeVelS.Physics.Callbacks.Structs
{
    using System;
    using System.Numerics;

    using BepuPhysics;

    using BepuUtilities;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/Demos/DemoCallbacks.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges)]
    public struct PoseIntegratorCallbacks : IPoseIntegratorCallbacks
    {
        public Vector3 Gravity;

        public float LinearDamping;

        public float AngularDamping;

        Vector3 gravityDt;

        public AngularIntegrationMode AngularIntegrationMode => AngularIntegrationMode.Nonconserving;

        public bool AllowSubstepsForUnconstrainedBodies => true;

        public bool IntegrateVelocityForKinematics => false;

        public PoseIntegratorCallbacks(
            Vector3 gravity,
            float linearDamping = .03f,
            float angularDamping = .03f) 
            : 
            this()
        {
            this.Gravity = gravity;

            this.LinearDamping = linearDamping;

            this.AngularDamping = angularDamping;
        }

        public void Initialize(
            Simulation simulation)
        {
        }

        Vector3Wide gravityWideDt;

        Vector<float> linearDampingDt;

        Vector<float> angularDampingDt;

        /// <summary>
        /// Callback invoked ahead of dispatches that may call into <see cref="IntegrateVelocity"/>.
        /// It may be called more than once with different values over a frame. For example, when performing bounding box prediction, velocity is integrated with a full frame time step duration.
        /// During substepped solves, integration is split into substepCount steps, each with fullFrameDuration / substepCount duration.
        /// The final integration pass for unconstrained bodies may be either fullFrameDuration or fullFrameDuration / substepCount, depending on the value of AllowSubstepsForUnconstrainedBodies. 
        /// </summary>
        /// <param name="dt">Current integration time step duration.</param>
        /// <remarks>This is typically used for precomputing anything expensive that will be used across velocity integration.</remarks>
        public void PrepareForIntegration(
            float dt)
        {
            // No reason to recalculate gravity * dt for every body; just cache it ahead of time.
            // Since these callbacks don't use per-body damping values, we can precalculate everything.
            this.linearDampingDt = new Vector<float>(
                MathF.Pow(
                    MathHelper.Clamp(
                        1 - this.LinearDamping,
                        0,
                        1),
                    dt));

            this.angularDampingDt = new Vector<float>(
                MathF.Pow(
                    MathHelper.Clamp(
                        1 - this.AngularDamping,
                        0,
                        1),
                    dt));

            this.gravityWideDt = Vector3Wide.Broadcast(
                this.Gravity * dt);
        }

        /// <summary>
        /// Callback for a bundle of bodies being integrated.
        /// </summary>
        /// <param name="bodyIndices">Indices of the bodies being integrated in this bundle.</param>
        /// <param name="position">Current body positions.</param>
        /// <param name="orientation">Current body orientations.</param>
        /// <param name="localInertia">Body's current local inertia.</param>
        /// <param name="integrationMask">Mask indicating which lanes are active in the bundle. Active lanes will contain 0xFFFFFFFF, inactive lanes will contain 0.</param>
        /// <param name="workerIndex">Index of the worker thread processing this bundle.</param>
        /// <param name="dt">Durations to integrate the velocity over. Can vary over lanes.</param>
        /// <param name="velocity">Velocity of bodies in the bundle. Any changes to lanes which are not active by the integrationMask will be discarded.</param>
        public void IntegrateVelocity(
            Vector<int> bodyIndices,
            Vector3Wide position,
            QuaternionWide orientation,
            BodyInertiaWide localInertia,
            Vector<int> integrationMask,
            int workerIndex,
            Vector<float> dt,
            ref BodyVelocityWide velocity)
        {
            // This is a handy spot to implement things like position dependent gravity or per-body damping.
            // This implementation uses a single damping value for all bodies that allows it to be precomputed.
            // We don't have to check for kinematics; IntegrateVelocityForKinematics returns false, so we'll never see them in this callback.
            // Note that these are SIMD operations and "Wide" types. There are Vector<float>.Count lanes of execution being evaluated simultaneously.
            // The types are laid out in array-of-structures-of-arrays (AOSOA) format. That's because this function is frequently called from vectorized contexts within the solver.
            // Transforming to "array of structures" (AOS) format for the callback and then back to AOSOA would involve a lot of overhead, so instead the callback works on the AOSOA representation directly.
            velocity.Linear = (velocity.Linear + this.gravityWideDt) * this.linearDampingDt;

            velocity.Angular = velocity.Angular * this.angularDampingDt;
        }
    }
}