namespace BeVelS.ECS.Systems.Debugging.InterfacesAbstractFactories
{
    using BeVelS.ECS.Systems.Debugging.InterfacesFactories;

    public interface IDebuggingAbstractFactory
    {
        IRenderDocDebuggerSystemFactory CreateRenderDocDebuggerSystemFactory();
    }
}