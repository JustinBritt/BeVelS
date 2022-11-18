namespace BeVelS.Graphics.Shapes.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BepuPhysics;
    using BepuPhysics.Collidables;

    using BeVelS.Graphics.Shapes.InterfacesFactories;
    using BeVelS.Graphics.Shapes.Structs;

    internal sealed class TriangleInstanceFactory : ITriangleInstanceFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TriangleInstanceFactory()
        {
        }

        public TriangleInstance Create(
            Vector3 A,
            Vector3 B,
            Vector3 C,
            Quaternion orientation,
            float X,
            float Y,
            float Z)
        {
            TriangleInstance instance = default;

            try
            {
                instance = new TriangleInstance();

                instance.A = A;

                instance.X = X;

                instance.B = B;

                instance.Y = Y;

                instance.C = C;

                instance.Z = Z;

                instance.Orientation = orientation;
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }

        public TriangleInstance Create(
            RigidPose rigidPose,
            Triangle triangle)
        {
            return this.Create(
                A: triangle.A,
                B: triangle.B,
                C: triangle.C,
                orientation: rigidPose.Orientation,
                X: rigidPose.Position.X,
                Y: rigidPose.Position.Y,
                Z: rigidPose.Position.Z);
        }
    }
}