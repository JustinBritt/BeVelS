namespace BeVelS.Physics.Constraints.InterfacesFactories
{
    using System.Numerics;

    using BepuPhysics.Constraints;

    public interface IPointOnLineServoFactory
    {
        PointOnLineServo Create(
            Vector3 localDirection,
            Vector3 localOffsetA,
            Vector3 localOffsetB,
            ServoSettings servoSettings,
            SpringSettings springSettings);
    }
}