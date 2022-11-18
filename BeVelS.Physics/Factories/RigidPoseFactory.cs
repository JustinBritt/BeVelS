namespace BeVelS.Physics.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BepuPhysics;

    using BeVelS.Physics.InterfacesFactories;

    internal sealed class RigidPoseFactory : IRigidPoseFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RigidPoseFactory()
        {
        }

        public RigidPose Create(
            Vector3 position)
        {
            RigidPose rigidPose = default;

            try
            {
                rigidPose = new RigidPose(
                    position);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return rigidPose;
        }

        public RigidPose Create(
            Quaternion orientation,
            Vector3 position)
        {
            RigidPose rigidPose = default;

            try
            {
                rigidPose = new RigidPose(
                    position,
                    orientation);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return rigidPose;
        }
    }
}