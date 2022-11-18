namespace BeVelS.Graphics.BlendStates.InterfacesAbstractFactories
{
    using BeVelS.Graphics.BlendStates.InterfacesFactories.Descriptions;

    public interface IBlendStatesAbstractFactory
    {
        IBlendAttachmentDescriptionFactory CreateBlendAttachmentDescriptionFactory();

        IBlendStateDescriptionFactory CreateBlendStateDescriptionFactory();
    }
}