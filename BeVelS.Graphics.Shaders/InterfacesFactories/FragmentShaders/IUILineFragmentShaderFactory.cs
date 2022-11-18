namespace BeVelS.Graphics.Shaders.InterfacesFactories.FragmentShaders
{
    using BeVelS.Graphics.Shaders.Interfaces.FragmentShaders;
    using BeVelS.Graphics.Shaders.InterfacesFactories.Descriptions;

    public interface IUILineFragmentShaderFactory
    {
        IUILineFragmentShader Create(
            IShaderDescriptionFactory shaderDescriptionFactory);
    }
}