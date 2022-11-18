namespace BeVelS.Common.Triangles.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BeVelS.Common.Triangles.InterfacesFactories;
    using BeVelS.Common.Triangles.Structs;

    internal sealed class TriangleContentFactory : ITriangleContentFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TriangleContentFactory()
        {
        }

        public TriangleContent Create(
            Vector3 A,
            Vector3 B,
            Vector3 C)
        {
            TriangleContent triangleContent = default;

            try
            {
                triangleContent = new TriangleContent(
                    A: A,
                    B: B,
                    C: C);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return triangleContent;
        }
    }
}