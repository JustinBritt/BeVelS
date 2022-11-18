namespace BeVelS.Physics.Constraints.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BepuPhysics.Constraints;

    using BeVelS.Physics.Constraints.InterfacesFactories;

    internal sealed class BallSocketFactory : IBallSocketFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BallSocketFactory()
        {
        }

        public BallSocket Create(
            Vector3 localOffsetA,
            Vector3 localOffsetB,
            SpringSettings springSettings)
        {
            BallSocket ballSocket = default;

            try
            {
                ballSocket.LocalOffsetA = localOffsetA;

                ballSocket.LocalOffsetB = localOffsetB;

                ballSocket.SpringSettings = springSettings;
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return ballSocket;
        }
    }
}