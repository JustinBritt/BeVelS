namespace BeVelS.Graphics.Framebuffers.InterfacesFactories.Descriptions
{
    using Veldrid;

    public interface IFramebufferDescriptionFactory
    {
        FramebufferDescription Create(
            Texture depthTarget,
            params Texture[] colorTargets);

        FramebufferDescription Create(
            FramebufferAttachmentDescription? depthTarget,
            FramebufferAttachmentDescription[] colorTargets);
    }
}