namespace BeVelS.Graphics.Shapes.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BepuPhysics;
    using BepuPhysics.Collidables;

    using BeVelS.Graphics.Shapes.InterfacesFactories;
    using BeVelS.Graphics.Shapes.Structs;

    internal sealed class CylinderInstanceFactory : ICylinderInstanceFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CylinderInstanceFactory()
        {
        }

        public unsafe CylinderInstance Create(
            float halfLength,
            Quaternion orientation,
            Vector3 position,
            float radius)
        {
            CylinderInstance instance = default;

            try
            {
                instance = new CylinderInstance();

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

        public CylinderInstance Create(
            Cylinder cylinder,
            RigidPose rigidPose)
        {
            return this.Create(
                halfLength: cylinder.HalfLength,
                orientation: rigidPose.Orientation,
                position: rigidPose.Position,
                radius: cylinder.Radius);
        }
    }
}