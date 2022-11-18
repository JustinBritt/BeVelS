namespace BeVelS.Graphics.Debugging.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Graphics.Debugging.Factories;
    using BeVelS.Graphics.Debugging.InterfacesAbstractFactories;
    using BeVelS.Graphics.Debugging.InterfacesFactories;

    public sealed class DebuggingAbstractFactory : IDebuggingAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DebuggingAbstractFactory()
        {
        }

        public IRenderDocDebuggerFactory CreateRenderDocDebuggerFactory()
        {
            IRenderDocDebuggerFactory factory = null;

            try
            {
                factory = new RenderDocDebuggerFactory();
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