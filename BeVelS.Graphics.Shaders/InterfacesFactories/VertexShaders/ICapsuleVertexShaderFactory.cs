namespace BeVelS.Graphics.Shaders.InterfacesFactories.VertexShaders
{
    using BeVelS.Graphics.Shaders.Interfaces.VertexShaders;
    using BeVelS.Graphics.Shaders.InterfacesFactories.Descriptions;

    public interface ICapsuleVertexShaderFactory
    {
        ICapsuleVertexShader Create(
            IShaderDescriptionFactory shaderDescriptionFactory);
    }
}