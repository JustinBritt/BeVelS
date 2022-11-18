namespace BeVelS.Graphics.Shapes.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BepuPhysics;
    using BepuPhysics.Collidables;

    using BeVelS.Graphics.Shapes.InterfacesFactories;
    using BeVelS.Graphics.Shapes.Structs;

    using BeVelS.Common.Utilities.Classes;

    internal sealed class SphereInstanceFactory : ISphereInstanceFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SphereInstanceFactory()
        {
        }

        public SphereInstance Create(
            Quaternion orientation,
            Vector3 position,
            float radius)
        {
            SphereInstance instance = default;

            try
            {
                instance = new SphereInstance();

                instance.Position = position;

                instance.Radius = radius;

                QuaternionUtilities.PackOrientation(
                    orientation,
                    out instance.PackedOrientation);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }

        public SphereInstance Create(
            RigidPose rigidPose,
            Sphere sphere)
        {
            return this.Create(
                orientation: rigidPose.Orientation,
                position: rigidPose.Position,
                radius: sphere.Radius);
        }
    }
}