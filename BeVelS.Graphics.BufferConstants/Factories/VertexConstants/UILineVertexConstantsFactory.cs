namespace BeVelS.Graphics.BufferConstants.Factories.VertexConstants
{
    using System;
    using System.Numerics;

    using log4net;

    using BeVelS.Graphics.BufferConstants.InterfacesFactories.VertexConstants;
    using BeVelS.Graphics.BufferConstants.Structs.VertexConstants;

    internal sealed class UILineVertexConstantsFactory : IUILineVertexConstantsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public UILineVertexConstantsFactory()
        {
        }

        public UILineVertexConstants Create(
            Vector2 packedToScreenScale,
            Vector2 screenToNDCScale)
        {
            UILineVertexConstants vertexConstants = default;

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