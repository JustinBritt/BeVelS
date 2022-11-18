namespace BeVelS.Physics.Callbacks.InterfacesAbstractFactories
{
    using BeVelS.Physics.Callbacks.InterfacesFactories;

    public interface ICallbacksAbstractFactory
    {
        INarrowPhaseCallbacksFactory CreateNarrowPhaseCallbacksFactory();

        IPoseIntegratorCallbacksFactory CreatePoseIntegratorCallbacksFactory();
    }
}