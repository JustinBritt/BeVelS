namespace BeVelS.Graphics.RasterizerStates.InterfacesAbstractFactories
{
    using BeVelS.Graphics.RasterizerStates.InterfacesFactories.Descriptions;

    public interface IRasterizerStatesAbstractFactory
    {
        IRasterizerStateDescriptionFactory CreateRasterizerStateDescriptionFactory();
    }
}