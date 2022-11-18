namespace BeVelS.Physics.InterfacesFactories
{
    using System.Numerics;

    using BepuPhysics;
    using BepuPhysics.Collidables;
    using BepuPhysics.Constraints;

    using BeVelS.Physics.Constraints.InterfacesFactories;

    public interface IConstraintHandleFactory
    {
        ConstraintHandle CreatePointOnLineServo(
            IPointOnLineServoFactory pointOnLineServoFactory,
            Vector3 localDirection,
            Vector3 localOffsetA,
            Vector3 localOffsetB,
            ServoSettings servoSettings,
            Simulation simulation,
            SpringSettings springSettings,
            CollidableReference a,
            CollidableReference b);
    }
}