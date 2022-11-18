namespace BeVelS.Graphics.Text.Factories
{
    using System;

    using log4net;

    using BeVelS.Graphics.Text.Classes;
    using BeVelS.Graphics.Text.Interfaces;
    using BeVelS.Graphics.Text.InterfacesFactories;

    internal sealed class TextBuilderFactory : ITextBuilderFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TextBuilderFactory()
        {
        }

        public ITextBuilder Create(
            int initialCapacity = 32)
        {
            ITextBuilder textBuilder = null;

            try
            {
                textBuilder = new TextBuilder(
                    initialCapacity);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return textBuilder;
        }
    }
}