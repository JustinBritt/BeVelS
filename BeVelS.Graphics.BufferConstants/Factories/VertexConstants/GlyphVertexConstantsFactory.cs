namespace BeVelS.Graphics.BufferConstants.Factories.VertexConstants
{
    using System;
    using System.Numerics;

    using log4net;

    using BeVelS.Graphics.BufferConstants.InterfacesFactories.VertexConstants;
    using BeVelS.Graphics.BufferConstants.Structs.VertexConstants;

    internal sealed class GlyphVertexConstantsFactory : IGlyphVertexConstantsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public GlyphVertexConstantsFactory()
        {
        }

        public GlyphVertexConstants Create(
            Vector2 inverseAtlasResolution,
            Vector2 packedToScreenScale,
            Vector2 screenToNDCScale)
        {
            GlyphVertexConstants vertexConstants = default;

            try
            {
                vertexConstants.InverseAtlasResolution = inverseAtlasResolution;

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