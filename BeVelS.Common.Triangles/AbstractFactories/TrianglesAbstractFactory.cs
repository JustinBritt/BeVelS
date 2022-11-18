namespace BeVelS.Common.Triangles.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Common.Triangles.Factories;
    using BeVelS.Common.Triangles.InterfacesAbstractFactories;
    using BeVelS.Common.Triangles.InterfacesFactories;

    public sealed class TrianglesAbstractFactory : ITrianglesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TrianglesAbstractFactory()
        {
        }

        public ITriangleContentFactory CreateTriangleContentFactory()
        {
            ITriangleContentFactory factory = null;

            try
            {
                factory = new TriangleContentFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}