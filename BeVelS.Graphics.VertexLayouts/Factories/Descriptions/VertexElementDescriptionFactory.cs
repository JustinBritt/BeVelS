namespace BeVelS.Graphics.VertexLayouts.Factories.Descriptions
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.VertexLayouts.InterfacesFactories.Descriptions;

    internal sealed class VertexElementDescriptionFactory : IVertexElementDescriptionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VertexElementDescriptionFactory()
        {
        }

        public VertexElementDescription Create(
            string name,
            VertexElementSemantic semantic,
            VertexElementFormat format)
        {
            VertexElementDescription vertexElementDescription = default;

            try
            {
                vertexElementDescription = new VertexElementDescription(
                    name,
                    semantic,
                    format);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return vertexElementDescription;
        }

        public VertexElementDescription Create(
            string name,
            VertexElementFormat format,
            VertexElementSemantic semantic)
        {
            VertexElementDescription vertexElementDescription = default;

            try
            {
                vertexElementDescription = new VertexElementDescription(
                    name,
                    format,
                    semantic);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return vertexElementDescription;
        }

        public VertexElementDescription Create(
            string name,
            VertexElementSemantic semantic,
            VertexElementFormat format,
            uint offset)
        {
            VertexElementDescription vertexElementDescription = default;

            try
            {
                vertexElementDescription = new VertexElementDescription(
                    name,
                    semantic,
                    format,
                    offset);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return vertexElementDescription;
        }
    }
}