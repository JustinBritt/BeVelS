namespace BeVelS.Graphics.Framebuffers.InterfacesAbstractFactories
{
    using BeVelS.Graphics.Framebuffers.InterfacesFactories.Descriptions;

    public interface IFramebuffersAbstractFactory
    {
        IFramebufferDescriptionFactory CreateFramebufferDescriptionFactory();
    }
}