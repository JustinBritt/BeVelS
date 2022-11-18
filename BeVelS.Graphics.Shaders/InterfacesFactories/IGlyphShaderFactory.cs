namespace BeVelS.Graphics.Shaders.InterfacesFactories
{
    using Veldrid;

    using BeVelS.Graphics.Shaders.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shaders.InterfacesFactories.FragmentShaders;
    using BeVelS.Graphics.Shaders.InterfacesFactories.VertexShaders;

    public interface IGlyphShaderFactory
    {
        Shader[] Create(
            IGlyphFragmentShaderFactory glyphFragmentShaderFactory,
            IGlyphVertexShaderFactory glyphVertexShaderFactory,
            IShaderDescriptionFactory shaderDescriptionFactory,
            GraphicsDevice graphicsDevice);
    }
}