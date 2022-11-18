namespace BeVelS.ECS.Components.Debugging.InterfacesFactories
{
    using BeVelS.ECS.Components.Debugging.Structs;

    using BeVelS.Graphics.Debugging.Interfaces;

    public interface IRenderDocDebuggerComponentFactory
    {
        RenderDocDebuggerComponent Create(
            IRenderDocDebugger value);
    }
}