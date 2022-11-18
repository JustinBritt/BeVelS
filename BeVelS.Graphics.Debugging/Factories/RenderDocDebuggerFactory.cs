namespace BeVelS.Graphics.Debugging.Factories
{
    using System;

    using log4net;

    using BeVelS.Graphics.Debugging.Classes;
    using BeVelS.Graphics.Debugging.Interfaces;
    using BeVelS.Graphics.Debugging.InterfacesFactories;

    internal sealed class RenderDocDebuggerFactory : IRenderDocDebuggerFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RenderDocDebuggerFactory()
        {
        }

        public IRenderDocDebugger Create()
        {
            IRenderDocDebugger RenderDocDebugger = null;

            try
            {
                RenderDocDebugger = new RenderDocDebugger();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return RenderDocDebugger;
        }
    }
}