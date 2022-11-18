namespace BeVelS.Physics.Callbacks.InterfacesFactories
{
    using System.Numerics;

    using BeVelS.Physics.Callbacks.Structs;

    public interface IPoseIntegratorCallbacksFactory
    {
        PoseIntegratorCallbacks Create(
            Vector3 gravity,
            float linearDamping = .03f,
            float angularDamping = .03f);
    }
}