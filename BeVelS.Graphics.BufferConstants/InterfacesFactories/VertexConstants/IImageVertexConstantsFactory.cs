namespace BeVelS.Graphics.BufferConstants.InterfacesFactories.VertexConstants
{
    using System.Numerics;

    using BeVelS.Graphics.BufferConstants.Structs.VertexConstants;

    public interface IImageVertexConstantsFactory
    {
        ImageVertexConstants Create(
            Vector2 packedToScreenScale,
            Vector2 screenToNDCScale);
    }
}