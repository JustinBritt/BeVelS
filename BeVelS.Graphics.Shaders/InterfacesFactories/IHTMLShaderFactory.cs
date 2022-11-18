namespace BeVelS.Graphics.Shaders.InterfacesFactories
{
    using Veldrid;

    using BeVelS.Graphics.Shaders.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shaders.InterfacesFactories.FragmentShaders;
    using BeVelS.Graphics.Shaders.InterfacesFactories.VertexShaders;

    public interface IHTMLShaderFactory
    {
        Shader[] Create(
            IHTMLFragmentShaderFactory HTMLFragmentShaderFactory,
            IHTMLVertexShaderFactory HTMLVertexShaderFactory,
            IShaderDescriptionFactory shaderDescriptionFactory,
            GraphicsDevice graphicsDevice);
    }
}