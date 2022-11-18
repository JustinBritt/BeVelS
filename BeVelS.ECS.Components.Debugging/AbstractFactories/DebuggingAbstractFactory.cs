namespace BeVelS.ECS.Components.Debugging.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Components.Debugging.Factories;
    using BeVelS.ECS.Components.Debugging.InterfacesAbstractFactories;
    using BeVelS.ECS.Components.Debugging.InterfacesFactories;

    public sealed class DebuggingAbstractFactory : IDebuggingAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DebuggingAbstractFactory()
        {
        }

        public IRenderDocDebuggerComponentFactory CreateRenderDocDebuggerComponentFactory()
        {
            IRenderDocDebuggerComponentFactory factory = null;

            try
            {
                factory = new RenderDocDebuggerComponentFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}