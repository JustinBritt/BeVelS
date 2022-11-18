namespace BeVelS.Physics.Collidables.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BepuPhysics.Collidables;
    
    using BepuUtilities.Memory;

    using BeVelS.Physics.Collidables.InterfacesFactories;

    internal sealed class MeshFactory : IMeshFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MeshFactory()
        {
        }

        public Mesh Create(
            Span<byte> data,
            BufferPool pool)
        {
            Mesh mesh = default;

            try
            {
                mesh = new Mesh(
                    data: data,
                    pool: pool);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return mesh;
        }

        public Mesh Create(
            Buffer<Triangle> triangles,
            Vector3 scale,
            BufferPool pool)
        {
            Mesh mesh = default;

            try
            {
                mesh = new Mesh(
                    triangles: triangles,
                    scale: scale,
                    pool: pool);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return mesh;
        }
    }
}