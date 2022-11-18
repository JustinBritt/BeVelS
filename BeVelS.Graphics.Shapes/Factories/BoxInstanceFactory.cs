namespace BeVelS.Graphics.Shapes.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BepuPhysics;
    using BepuPhysics.Collidables;

    using BeVelS.Graphics.Shapes.InterfacesFactories;
    using BeVelS.Graphics.Shapes.Structs;

    internal sealed class BoxInstanceFactory : IBoxInstanceFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BoxInstanceFactory()
        {
        }

        public BoxInstance Create(
            float halfHeight,
            float halfLength,
            float halfWidth,
            Quaternion orientation,
            Vector3 position)
        {
            BoxInstance instance = default;

            try
            {
                instance = new BoxInstance();

                instance.Position = position;

                instance.Orientation = orientation;

                instance.HalfExtents = this.CalculateHalfExtents(
                    halfHeight: halfHeight,
                    halfLength: halfLength,
                    halfWidth: halfWidth);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }

        public BoxInstance Create(
            Box box,
            RigidPose rigidPose)
        {
            return this.Create(
                halfHeight: box.HalfHeight,
                halfLength: box.HalfLength,
                halfWidth: box.HalfWidth,
                orientation: rigidPose.Orientation,
                position: rigidPose.Position);
        }

        private Vector4 CalculateHalfExtents(
            float halfHeight,
            float halfLength,
            float halfWidth)
        {
            Vector4 halfExtents = Vector4.Zero;

            halfExtents.X = halfWidth;

            halfExtents.Y = halfHeight;

            halfExtents.Z = halfLength;

            halfExtents.W = 0;

            return halfExtents;
        }
    }
}