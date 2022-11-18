namespace BeVelS.Physics.Factories
{
    using System.Numerics;

    using BepuPhysics;
    using BepuPhysics.Collidables;
    using BepuPhysics.Constraints;

    using BeVelS.Physics.InterfacesFactories;

    using BeVelS.Physics.Constraints.InterfacesFactories;

    internal sealed class ConstraintHandleFactory : IConstraintHandleFactory
    {
        public ConstraintHandleFactory()
        {
        }

        public ConstraintHandle CreatePointOnLineServo(
            IPointOnLineServoFactory pointOnLineServoFactory,
            Vector3 localDirection,
            Vector3 localOffsetA,
            Vector3 localOffsetB,
            ServoSettings servoSettings,
            Simulation simulation,
            SpringSettings springSettings,
            CollidableReference a,
            CollidableReference b)
        {
            return simulation.Solver.Add(
                bodyHandleA: a.BodyHandle,
                bodyHandleB: b.BodyHandle,
                description: pointOnLineServoFactory.Create(
                    localDirection: localDirection,
                    localOffsetA: localOffsetA,
                    localOffsetB: localOffsetB,
                    servoSettings: servoSettings,
                    springSettings: springSettings));
        }
    }
}