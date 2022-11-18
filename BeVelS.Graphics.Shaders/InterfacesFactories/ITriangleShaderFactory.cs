namespace BeVelS.Graphics.Shaders.InterfacesFactories
{
    using Veldrid;

    using BeVelS.Graphics.Shaders.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shaders.InterfacesFactories.FragmentShaders;
    using BeVelS.Graphics.Shaders.InterfacesFactories.VertexShaders;

    public interface ITriangleShaderFactory
    {
        Shader[] Create(
            IShaderDescriptionFactory shaderDescriptionFactory,
            ITriangleFragmentShaderFactory triangleFragmentShaderFactory,
            ITriangleVertexShaderFactory triangleVertexShaderFactory,
            GraphicsDevice graphicsDevice);
    }
}