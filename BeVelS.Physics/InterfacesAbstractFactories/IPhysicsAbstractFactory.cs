namespace BeVelS.Physics.InterfacesAbstractFactories
{
    using BeVelS.Physics.InterfacesFactories;

    public interface IPhysicsAbstractFactory
    {
        IBodyActivityDescriptionFactory CreateBodyActivityDescriptionFactory();

        IBodyDescriptionFactory CreateBodyDescriptionFactory();

        IBodyInertiaFactory CreateBodyInertiaFactory();

        IBodyVelocityFactory CreateBodyVelocityFactory();

        IConstraintHandleFactory CreateConstraintHandleFactory();

        IDefaultTimestepperFactory CreateDefaultTimestepperFactory();

        IRigidPoseFactory CreateRigidPoseFactory();

        ISolveDescriptionFactory CreateSolveDescriptionFactory();

        IStaticDescriptionFactory CreateStaticDescriptionFactory();
    }
}