namespace BeVelS.Graphics.BufferConstants.InterfacesFactories.FragmentConstants
{
    using System.Numerics;

    using BeVelS.Graphics.BufferConstants.Structs.FragmentConstants;

    public interface ISphereFragmentConstantsFactory
    {
        SphereFragmentConstants Create(
            Vector3 cameraBackward,
            Vector3 cameraRight,
            Vector3 cameraUp,
            float farClip,
            float nearClip,
            Vector2 pixelSizeAtUnitPlane);
    }
}