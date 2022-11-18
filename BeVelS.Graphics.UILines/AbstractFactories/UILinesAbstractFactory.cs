namespace BeVelS.Graphics.UILines.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Graphics.UILines.Factories;
    using BeVelS.Graphics.UILines.InterfacesAbstractFactories;
    using BeVelS.Graphics.UILines.InterfacesFactories;

    public sealed class UILinesAbstractFactory : IUILinesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public UILinesAbstractFactory()
        {
        }

        public IUILineInstanceFactory CreateUILineInstanceFactory()
        {
            IUILineInstanceFactory factory = null;

            try
            {
                factory = new UILineInstanceFactory();
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