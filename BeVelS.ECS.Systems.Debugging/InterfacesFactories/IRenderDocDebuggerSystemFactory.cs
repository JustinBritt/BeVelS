namespace BeVelS.ECS.Systems.Debugging.InterfacesFactories
{
    using DefaultEcs;

    using BeVelS.ECS.Systems.Debugging.Interfaces;

    using BeVelS.Graphics.Debugging.InterfacesFactories;

    public interface IRenderDocDebuggerSystemFactory
    {
        IRenderDocDebuggerSystem Create(
            IRenderDocDebuggerFactory RenderDocDebuggerFactory,
            World world);
    }
}