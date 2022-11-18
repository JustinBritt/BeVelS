namespace BeVelS.Graphics.Samplers.InterfacesAbstractFactories
{
    using BeVelS.Graphics.Samplers.InterfacesFactories.Descriptions;

    public interface ISamplersAbstractFactory
    {
        ISamplerDescriptionFactory CreateSamplerDescriptionFactory();
    }
}