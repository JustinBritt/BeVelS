namespace BeVelS.Graphics.Vertices.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Graphics.Vertices.Factories;
    using BeVelS.Graphics.Vertices.InterfacesAbstractFactories;
    using BeVelS.Graphics.Vertices.InterfacesFactories;

    public sealed class VerticesAbstractFactory : IVerticesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VerticesAbstractFactory()
        {
        }

        public IPositionColorVertexFactory CreatePositionColorVertexFactory()
        {
            IPositionColorVertexFactory factory = null;

            try
            {
                factory = new PositionColorVertexFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IPositionUVVertexFactory CreatePositionUVVertexFactory()
        {
            IPositionUVVertexFactory factory = null;

            try
            {
                factory = new PositionUVVertexFactory();
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