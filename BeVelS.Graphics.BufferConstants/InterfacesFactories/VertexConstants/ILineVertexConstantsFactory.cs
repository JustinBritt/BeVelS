namespace BeVelS.Graphics.BufferConstants.InterfacesFactories.VertexConstants
{
    using System.Numerics;

    using BeVelS.Graphics.BufferConstants.Structs.VertexConstants;

    public interface ILineVertexConstantsFactory
    {
        LineVertexConstants Create(
            Vector3 cameraForward,
            Vector3 cameraPosition,
            Vector3 cameraRight,
            Vector2 NDCToScreenScale,
            float tanAnglePerPixel,
            Matrix4x4 viewProjection);
    }
}