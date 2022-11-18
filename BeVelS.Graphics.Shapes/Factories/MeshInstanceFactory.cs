namespace BeVelS.Graphics.Shapes.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BepuPhysics;
    using BepuPhysics.Collidables;

    using BeVelS.Graphics.Shapes.InterfacesFactories;
    using BeVelS.Graphics.Shapes.Structs;

    internal sealed class MeshInstanceFactory : IMeshInstanceFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MeshInstanceFactory()
        {
        }

        public MeshInstance Create(
            Quaternion orientation,
            Vector3 position,
            Vector3 scale,
            int vertexCount,
            int vertexStart)
        {
            MeshInstance instance = default;

            try
            {
                instance = new MeshInstance();

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

        public MeshInstance Create(
            Mesh mesh,
            RigidPose rigidPose,
            int vertexCount = 0,
            int vertexStart = 0)
        {
            return this.Create(
                orientation: rigidPose.Orientation,
                position: rigidPose.Position,
                scale: mesh.Scale,
                vertexCount: vertexCount,
                vertexStart: vertexStart);
        }
    }
}