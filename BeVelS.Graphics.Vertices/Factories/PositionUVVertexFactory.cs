namespace BeVelS.Graphics.Vertices.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using BeVelS.Graphics.Vertices.InterfacesFactories;
    using BeVelS.Graphics.Vertices.Structs;

    internal sealed class PositionUVVertexFactory : IPositionUVVertexFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PositionUVVertexFactory()
        {
        }

        public PositionUVVertex Create(
            Vector3 position,
            Vector2 UV)
        {
            PositionUVVertex vertex = default;

            try
            {
                vertex = new PositionUVVertex(
                    position,
                    UV);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return vertex;
        }
    }
}