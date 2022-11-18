namespace BeVelS.Graphics.ShaderSets.InterfacesFactories.Descriptions
{
    using Veldrid;

    public interface IShaderSetDescriptionFactory
    {
        ShaderSetDescription Create(
            Shader[] shaders);

        ShaderSetDescription Create(
            VertexLayoutDescription[] vertexLayouts,
            Shader[] shaders);

        ShaderSetDescription Create(
            VertexLayoutDescription[] vertexLayouts,
            Shader[] shaders,
            SpecializationConstant[] specializations);
    }
}