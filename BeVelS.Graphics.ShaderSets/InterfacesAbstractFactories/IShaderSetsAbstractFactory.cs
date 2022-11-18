namespace BeVelS.Graphics.ShaderSets.InterfacesAbstractFactories
{
    using BeVelS.Graphics.ShaderSets.InterfacesFactories.Descriptions;

    public interface IShaderSetsAbstractFactory
    {
        IShaderSetDescriptionFactory CreateShaderSetDescriptionFactory();
    }
}