namespace BeVelS.Graphics.BufferConstants.Factories.VertexConstants
{
    using System;
    using System.Numerics;

    using log4net;

    using BeVelS.Graphics.BufferConstants.InterfacesFactories.VertexConstants;
    using BeVelS.Graphics.BufferConstants.Structs.VertexConstants;

    internal sealed class SphereVertexConstantsFactory : ISphereVertexConstantsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SphereVertexConstantsFactory()
        {
        }

        public SphereVertexConstants Create(
            Vector3 cameraBackward,
            Vector3 cameraPosition,
            Vector3 cameraRight,
            Vector3 cameraUp,
            float nearClip,
            Matrix4x4 projection)
        {
            SphereVertexConstants vertexConstants = default;

            try
            {
                vertexConstants.CameraBackward = cameraBackward;

                vertexConstants.CameraPosition = cameraPosition;

                vertexConstants.CameraRight = cameraRight;

                vertexConstants.CameraUp = cameraUp;

                vertexConstants.NearClip = nearClip;

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