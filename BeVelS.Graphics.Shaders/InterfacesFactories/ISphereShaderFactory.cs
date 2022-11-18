namespace BeVelS.Graphics.Shaders.InterfacesFactories
{
    using Veldrid;

    using BeVelS.Graphics.Shaders.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shaders.InterfacesFactories.FragmentShaders;
    using BeVelS.Graphics.Shaders.InterfacesFactories.VertexShaders;

    public interface ISphereShaderFactory
    {
        Shader[] Create(
            IShaderDescriptionFactory shaderDescriptionFactory,
            ISphereFragmentShaderFactory sphereFragmentShaderFactory,
            ISphereVertexShaderFactory sphereVertexShaderFactory,
            GraphicsDevice graphicsDevice);
    }
}