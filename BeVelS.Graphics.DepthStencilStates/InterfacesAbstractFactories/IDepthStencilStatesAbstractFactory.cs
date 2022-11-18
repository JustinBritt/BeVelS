namespace BeVelS.Graphics.DepthStencilStates.InterfacesAbstractFactories
{
    using BeVelS.Graphics.DepthStencilStates.InterfacesFactories.Descriptions;

    public interface IDepthStencilStatesAbstractFactory
    {
        IDepthStencilStateDescriptionFactory CreateDepthStencilStateDescriptionFactory();
    }
}