namespace BeVelS.Physics.Constraints.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BepuPhysics.Constraints;

    using BeVelS.Physics.Constraints.InterfacesFactories;

    internal sealed class PointOnLineServoFactory : IPointOnLineServoFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PointOnLineServoFactory()
        {
        }

        public PointOnLineServo Create(
            Vector3 localDirection,
            Vector3 localOffsetA,
            Vector3 localOffsetB,
            ServoSettings servoSettings,
            SpringSettings springSettings)
        {
            PointOnLineServo pointOnLineServo = default;

            try
            {
                pointOnLineServo.LocalOffsetA = localOffsetA;

                pointOnLineServo.LocalOffsetB = localOffsetB;

                pointOnLineServo.LocalDirection = localDirection;

                pointOnLineServo.SpringSettings = springSettings;

                pointOnLineServo.ServoSettings = servoSettings;
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return pointOnLineServo;
        }
    }
}