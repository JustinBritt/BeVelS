namespace BeVelS.Graphics.Shaders.InterfacesFactories
{
    using Veldrid;

    using BeVelS.Graphics.Shaders.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shaders.InterfacesFactories.FragmentShaders;
    using BeVelS.Graphics.Shaders.InterfacesFactories.VertexShaders;

    public interface ILineShaderFactory
    {
        Shader[] Create(
            ILineFragmentShaderFactory lineFragmentShaderFactory,
            ILineVertexShaderFactory lineVertexShaderFactory,
            IShaderDescriptionFactory shaderDescriptionFactory,
            GraphicsDevice graphicsDevice);
    }
}