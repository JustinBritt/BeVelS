namespace BeVelS.Graphics.Shapes.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BepuPhysics;
    using BepuPhysics.Collidables;

    using BeVelS.Graphics.Shapes.InterfacesFactories;
    using BeVelS.Graphics.Shapes.Structs;

    internal sealed class CapsuleInstanceFactory : ICapsuleInstanceFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CapsuleInstanceFactory()
        {
        }

        public CapsuleInstance Create(
            float halfLength,
            Quaternion orientation,
            Vector3 position,
            float radius)
        {
            CapsuleInstance instance = default;

            try
            {
                instance = new CapsuleInstance();

                instance.Position = position;

                instance.Radius = radius;

                instance.Orientation = orientation;

                instance.HalfLength = halfLength;
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }

        public CapsuleInstance Create(
            Capsule capsule,
            RigidPose rigidPose)
        {
            return this.Create(
                halfLength: capsule.HalfLength,
                orientation: rigidPose.Orientation,
                position: rigidPose.Position,
                radius: capsule.Radius);
        }
    }
}