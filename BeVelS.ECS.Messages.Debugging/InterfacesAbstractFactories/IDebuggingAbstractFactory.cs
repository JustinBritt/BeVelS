namespace BeVelS.ECS.Messages.Debugging.InterfacesAbstractFactories
{
    using BeVelS.ECS.Messages.Debugging.InterfacesFactories;

    public interface IDebuggingAbstractFactory
    {
        IRenderDocEndFrameCaptureMessageFactory CreateRenderDocEndFrameCaptureMessageFactory();

        IRenderDocLaunchReplayUIMessageFactory CreateRenderDocLaunchReplayUIMessageFactory();

        IRenderDocStartFrameCaptureMessageFactory CreateRenderDocStartFrameCaptureMessageFactory();

        IRenderDocTriggerCaptureMessageFactory CreateRenderDocTriggerCaptureMessageFactory();
    }
}