namespace BeVelS.Graphics.Shaders.InterfacesFactories
{
    using Veldrid;

    using BeVelS.Graphics.Shaders.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shaders.InterfacesFactories.FragmentShaders;
    using BeVelS.Graphics.Shaders.InterfacesFactories.VertexShaders;

    public interface ICapsuleShaderFactory
    {
        Shader[] Create(
            ICapsuleFragmentShaderFactory capsuleFragmentShaderFactory,
            ICapsuleVertexShaderFactory capsuleVertexShaderFactory,
            IShaderDescriptionFactory shaderDescriptionFactory,
            GraphicsDevice graphicsDevice);
    }
}