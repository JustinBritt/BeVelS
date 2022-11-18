namespace BeVelS.Graphics.BufferConstants.InterfacesFactories.VertexConstants
{
    using System.Numerics;

    using BeVelS.Graphics.BufferConstants.Structs.VertexConstants;

    public interface ISphereVertexConstantsFactory
    {
        SphereVertexConstants Create(
            Vector3 cameraBackward,
            Vector3 cameraPosition,
            Vector3 cameraRight,
            Vector3 cameraUp,
            float nearClip,
            Matrix4x4 projection);
    }
}