namespace BeVelS.ECS.Components.Debugging.Factories
{
    using System;

    using log4net;

    using BeVelS.ECS.Components.Debugging.InterfacesFactories;
    using BeVelS.ECS.Components.Debugging.Structs;

    using BeVelS.Graphics.Debugging.Interfaces;

    internal sealed class RenderDocDebuggerComponentFactory : IRenderDocDebuggerComponentFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RenderDocDebuggerComponentFactory()
        {
        }

        public RenderDocDebuggerComponent Create(
            IRenderDocDebugger value)
        {
            RenderDocDebuggerComponent component = default;

            try
            {
                component = new RenderDocDebuggerComponent(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return component;
        }
    }
}