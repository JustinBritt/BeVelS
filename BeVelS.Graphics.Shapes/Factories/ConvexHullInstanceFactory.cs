namespace BeVelS.Graphics.Shapes.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BepuPhysics;
    using BepuPhysics.Collidables;

    using BeVelS.Graphics.Shapes.InterfacesFactories;
    using BeVelS.Graphics.Shapes.Structs;

    internal sealed class ConvexHullInstanceFactory : IConvexHullInstanceFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConvexHullInstanceFactory()
        {
        }

        public ConvexHullInstance Create(
            Quaternion orientation,
            Vector3 position,
            Vector3 scale,
            int vertexCount,
            int vertexStart)
        {
            ConvexHullInstance instance = default;

            try
            {
                instance = new ConvexHullInstance();

                instance.Position = position;

                instance.VertexStart = vertexStart;

                instance.Orientation = orientation;

                instance.Scale = scale;

                instance.VertexCount = vertexCount;
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }

        public ConvexHullInstance Create(
            ConvexHull convexHull,
            RigidPose rigidPose,
            int vertexCount = 0,
            int vertexStart = 0)
        {
            return this.Create(
                orientation: rigidPose.Orientation,
                position: rigidPose.Position,
                scale: Vector3.One,
                vertexCount: vertexCount,
                vertexStart: vertexStart);
        }
    }
}