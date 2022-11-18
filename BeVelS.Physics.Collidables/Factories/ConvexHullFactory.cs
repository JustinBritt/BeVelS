namespace BeVelS.Physics.Collidables.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BepuPhysics.Collidables;

    using BepuUtilities.Memory;

    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Physics.Collidables.InterfacesFactories;

    internal sealed class ConvexHullFactory : IConvexHullFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConvexHullFactory()
        {
        }

        public ConvexHull Create(
            Span<Vector3> points,
            BufferPool pool,
            out Vector3 center)
        {
            ConvexHull convexHull = default;

            center = default;

            try
            {
                convexHull = new ConvexHull(
                    points: points,
                    pool: pool,
                    center: out center);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return convexHull;
        }

        public ConvexHull Create(
            BufferPool bufferPool,
            Mesh mesh,
            Vector3 scaling)
        {
            Span<Vector3> points = (Span<Vector3>)Array.CreateInstance(
                typeof(Vector3),
                mesh.Triangles.Length * 3);

            for (int i = 0; i < mesh.Triangles.Length; i = i + 1)
            {
                ref var triangle = ref mesh.Triangles[i];

                int baseIndex = i * 3;

                points[baseIndex] = triangle.A;

                points[baseIndex + 1] = triangle.B;

                points[baseIndex + 2] = triangle.C;
            }

            return this.Create(
                this.ScaleSpanVector3(
                    scaling,
                    points),
                bufferPool,
                out Vector3 center);
        }

        private ReadOnlySpan<Vector3> CreateRandomSpanVector3(
            IVector3Factory vector3Factory,
            int count,
            int seed)
        {
            Random random = new Random(
                seed);

            Span<Vector3> vectors = (Span<Vector3>)Array.CreateInstance(
                typeof(Vector3),
                count);

            for (int i = 0; i < count; i = i + 1)
            {
                vectors[i] = vector3Factory.Create(
                    (float)random.NextDouble(),
                    (float)random.NextDouble(),
                    (float)random.NextDouble());
            }

            return vectors;
        }

        private Span<Vector3> ScaleSpanVector3(
            Vector3 scaling,
            ReadOnlySpan<Vector3> vectors)
        {
            Span<Vector3> scaledVectors = (Span<Vector3>)Array.CreateInstance(
                typeof(Vector3),
                vectors.Length);

            for (int i = 0; i < vectors.Length; i = i + 1)
            {
                scaledVectors[i] =
                    scaling
                    *
                    vectors[i];
            }

            return scaledVectors;
        }

        public ConvexHull CreateRandom(
            IVector3Factory vector3Factory,
            BufferPool bufferPool,
            int pointCount,
            Vector3 scaling,
            int seed)
        {
            return this.Create(
                points: this.ScaleSpanVector3(
                    scaling,
                    this.CreateRandomSpanVector3(
                        vector3Factory,
                        pointCount,
                        seed)),
                pool: bufferPool,
                center: out _);
        }
    }
}