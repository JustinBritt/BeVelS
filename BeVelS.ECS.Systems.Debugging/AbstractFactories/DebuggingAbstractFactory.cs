namespace BeVelS.ECS.Systems.Debugging.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Systems.Debugging.Factories;
    using BeVelS.ECS.Systems.Debugging.InterfacesAbstractFactories;
    using BeVelS.ECS.Systems.Debugging.InterfacesFactories;

    public sealed class DebuggingAbstractFactory : IDebuggingAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DebuggingAbstractFactory()
        {
        }

        public IRenderDocDebuggerSystemFactory CreateRenderDocDebuggerSystemFactory()
        {
            IRenderDocDebuggerSystemFactory factory = null;

            try
            {
                factory = new RenderDocDebuggerSystemFactory();
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