namespace BeVelS.ECS.Messages.Renderers.InterfacesAbstractFactories
{
    using BeVelS.ECS.Messages.Renderers.InterfacesFactories;

    public interface IRenderersAbstractFactory
    {
        IRenderableHTMLDrawMessageFactory CreateRenderableHTMLDrawMessageFactory();

        IRenderableImageDrawMessageFactory CreateRenderableImageDrawMessageFactory();

        ITextBuilderWriteMessageFactory CreateTextBuilderWriteMessageFactory();

        IUILineDrawMessageFactory CreateUILineDrawMessageFactory();
    }
}