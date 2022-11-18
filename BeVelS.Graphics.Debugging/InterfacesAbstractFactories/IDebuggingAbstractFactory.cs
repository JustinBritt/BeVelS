namespace BeVelS.Graphics.Debugging.InterfacesAbstractFactories
{
    using BeVelS.Graphics.Debugging.InterfacesFactories;

    public interface IDebuggingAbstractFactory
    {
        IRenderDocDebuggerFactory CreateRenderDocDebuggerFactory();
    }
}