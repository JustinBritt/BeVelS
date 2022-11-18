namespace BeVelS.ECS.Components.Debugging.InterfacesAbstractFactories
{
    using BeVelS.ECS.Components.Debugging.InterfacesFactories;

    public interface IDebuggingAbstractFactory
    {
        IRenderDocDebuggerComponentFactory CreateRenderDocDebuggerComponentFactory();
    }
}