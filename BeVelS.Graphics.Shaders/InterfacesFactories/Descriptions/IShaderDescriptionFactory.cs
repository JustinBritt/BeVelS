namespace BeVelS.Graphics.Shaders.InterfacesFactories.Descriptions
{
    using Veldrid;

    public interface IShaderDescriptionFactory
    {
        ShaderDescription Create(
            ShaderStages stage,
            byte[] shaderBytes,
            string entryPoint);

        ShaderDescription Create(
            ShaderStages stage,
            byte[] shaderBytes,
            string entryPoint,
            bool debug);

        ShaderDescription CreateFragmentShader(
            byte[] shaderBytes);

        ShaderDescription CreateFragmentShader(
            byte[] shaderBytes,
            bool debug);

        ShaderDescription CreateVertexShader(
            byte[] shaderBytes);

        ShaderDescription CreateVertexShader(
            byte[] shaderBytes,
            bool debug);
    }
}