namespace BeVelS.Graphics.BufferConstants.Factories.VertexConstants
{
    using System;
    using System.Numerics;

    using log4net;

    using BeVelS.Graphics.BufferConstants.InterfacesFactories.VertexConstants;
    using BeVelS.Graphics.BufferConstants.Structs.VertexConstants;
    
    internal sealed class HTMLVertexConstantsFactory : IHTMLVertexConstantsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HTMLVertexConstantsFactory()
        {
        }

        public HTMLVertexConstants Create(
            Vector2 packedToScreenScale,
            Vector2 screenToNDCScale)
        {
            HTMLVertexConstants vertexConstants = default;

            try
            {
                vertexConstants.PackedToScreenScale = packedToScreenScale;

                vertexConstants.ScreenToNDCScale = screenToNDCScale;
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return vertexConstants;
        }
    }
}