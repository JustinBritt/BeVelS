namespace BeVelS.Graphics.Shaders.InterfacesFactories
{
    using Veldrid;

    using BeVelS.Graphics.Shaders.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Shaders.InterfacesFactories.FragmentShaders;
    using BeVelS.Graphics.Shaders.InterfacesFactories.VertexShaders;

    public interface ICylinderShaderFactory
    {
        Shader[] Create(
            ICylinderFragmentShaderFactory cylinderFragmentShaderFactory,
            ICylinderVertexShaderFactory cylinderVertexShaderFactory,
            IShaderDescriptionFactory shaderDescriptionFactory,
            GraphicsDevice graphicsDevice);
    }
}