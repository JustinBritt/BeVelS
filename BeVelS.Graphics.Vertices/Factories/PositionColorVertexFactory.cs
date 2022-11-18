namespace BeVelS.Graphics.Vertices.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.Vertices.InterfacesFactories;
    using BeVelS.Graphics.Vertices.Structs;

    internal sealed class PositionColorVertexFactory : IPositionColorVertexFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PositionColorVertexFactory()
        {
        }

        public PositionColorVertex Create(
            Vector3 position,
            RgbaFloat color)
        {
            PositionColorVertex vertex = default;

            try
            {
                vertex = new PositionColorVertex(
                    position,
                    color);
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