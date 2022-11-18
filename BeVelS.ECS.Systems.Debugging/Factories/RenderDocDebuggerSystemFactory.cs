namespace BeVelS.ECS.Systems.Debugging.Factories
{
    using System;

    using log4net;

    using DefaultEcs;

    using BeVelS.ECS.Systems.Debugging.Classes;
    using BeVelS.ECS.Systems.Debugging.Interfaces;
    using BeVelS.ECS.Systems.Debugging.InterfacesFactories;

    using BeVelS.Graphics.Debugging.InterfacesFactories;

    internal sealed class RenderDocDebuggerSystemFactory : IRenderDocDebuggerSystemFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RenderDocDebuggerSystemFactory()
        {
        }

        public IRenderDocDebuggerSystem Create(
            IRenderDocDebuggerFactory RenderDocDebuggerFactory,
            World world)
        {
            IRenderDocDebuggerSystem system = null;

            try
            {
                system = new RenderDocDebuggerSystem(
                    RenderDocDebuggerFactory,
                    world);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return system;
        }
    }
}