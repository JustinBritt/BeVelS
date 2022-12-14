namespace BeVelS.Graphics.BufferConstants.Factories.VertexConstants
{
    using System;
    using System.Numerics;

    using log4net;

    using BeVelS.Graphics.BufferConstants.InterfacesFactories.VertexConstants;
    using BeVelS.Graphics.BufferConstants.Structs.VertexConstants;
    
    internal sealed class BoxVertexConstantsFactory : IBoxVertexConstantsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BoxVertexConstantsFactory()
        {
        }

        public BoxVertexConstants Create(
            Vector3 cameraBackward,
            Vector3 cameraPosition,
            Vector3 cameraRight,
            Vector3 cameraUp,
            Matrix4x4 projection)
        {
            BoxVertexConstants vertexConstants = default;

            try
            {
                vertexConstants.CameraBackward = cameraBackward;

                vertexConstants.CameraPosition = cameraPosition;

                vertexConstants.CameraRight = cameraRight;

                vertexConstants.CameraUp = cameraUp;

                vertexConstants.Projection = projection;
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