namespace BeVelS.Graphics.Text.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Graphics.Text.Factories;
    using BeVelS.Graphics.Text.InterfacesAbstractFactories;
    using BeVelS.Graphics.Text.InterfacesFactories;

    public sealed class TextAbstractFactory : ITextAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TextAbstractFactory()
        {
        }

        public ITextBuilderFactory CreateTextBuilderFactory()
        {
            ITextBuilderFactory factory = null;

            try
            {
                factory = new TextBuilderFactory();
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