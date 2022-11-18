namespace BeVelS.Graphics.Shaders.InterfacesFactories
{
    using Veldrid;

    using BeVelS.Graphics.Shaders.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shaders.InterfacesFactories.FragmentShaders;
    using BeVelS.Graphics.Shaders.InterfacesFactories.VertexShaders;

    public interface IUILineShaderFactory
    {
        Shader[] Create(
            IShaderDescriptionFactory shaderDescriptionFactory,
            IUILineFragmentShaderFactory UILineFragmentShaderFactory,
            IUILineVertexShaderFactory UILineVertexShaderFactory,
            GraphicsDevice graphicsDevice);
    }
}