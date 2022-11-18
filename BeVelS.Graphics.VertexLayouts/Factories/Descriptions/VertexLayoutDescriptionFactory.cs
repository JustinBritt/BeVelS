namespace BeVelS.Graphics.VertexLayouts.Factories.Descriptions
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.VertexLayouts.InterfacesFactories.Descriptions;

    internal sealed class VertexLayoutDescriptionFactory : IVertexLayoutDescriptionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VertexLayoutDescriptionFactory()
        {
        }

        public VertexLayoutDescription Create(
            params VertexElementDescription[] elements)
        {
            VertexLayoutDescription vertexLayoutDescription = default;

            try
            {
                vertexLayoutDescription = new VertexLayoutDescription(
                    elements);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return vertexLayoutDescription;
        }

        public VertexLayoutDescription Create(
            uint stride,
            params VertexElementDescription[] elements)
        {
            VertexLayoutDescription vertexLayoutDescription = default;

            try
            {
                vertexLayoutDescription = new VertexLayoutDescription(
                    stride,
                    elements);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return vertexLayoutDescription;
        }

        public VertexLayoutDescription Create(
           uint stride,
           uint instanceStepRate,
           params VertexElementDescription[] elements)
        {
            VertexLayoutDescription vertexLayoutDescription = default;

            try
            {
                vertexLayoutDescription = new VertexLayoutDescription(
                    stride,
                    instanceStepRate,
                    elements);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return vertexLayoutDescription;
        }
    }
}