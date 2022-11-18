namespace BeVelS.Physics.Callbacks.InterfacesFactories
{
    using BepuPhysics.Constraints;

    using BeVelS.Physics.Callbacks.Structs;

    public interface INarrowPhaseCallbacksFactory
    {
        NarrowPhaseCallbacks Create();

        NarrowPhaseCallbacks Create(
            SpringSettings contactSpringiness,
            float maximumRecoveryVelocity = 2f,
            float frictionCoefficient = 1f);
    }
}