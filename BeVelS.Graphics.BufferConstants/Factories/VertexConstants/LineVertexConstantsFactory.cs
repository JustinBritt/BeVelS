namespace BeVelS.Graphics.BufferConstants.Factories.VertexConstants
{
    using System;
    using System.Numerics;

    using log4net;

    using BeVelS.Graphics.BufferConstants.InterfacesFactories.VertexConstants;
    using BeVelS.Graphics.BufferConstants.Structs.VertexConstants;

    internal sealed class LineVertexConstantsFactory : ILineVertexConstantsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LineVertexConstantsFactory()
        {
        }

        public LineVertexConstants Create(
            Vector3 cameraForward,
            Vector3 cameraPosition,
            Vector3 cameraRight,
            Vector2 NDCToScreenScale,
            float tanAnglePerPixel,
            Matrix4x4 viewProjection)
        {
            LineVertexConstants vertexConstants = default;

            try
            {
                vertexConstants.CameraForward = cameraForward;

                vertexConstants.CameraPosition = cameraPosition;

                vertexConstants.CameraRight = cameraRight;

                vertexConstants.NDCToScreenScale = NDCToScreenScale;

                vertexConstants.TanAnglePerPixel = tanAnglePerPixel;

                vertexConstants.ViewProjection = viewProjection;
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