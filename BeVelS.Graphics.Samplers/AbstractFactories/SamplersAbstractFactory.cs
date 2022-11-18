namespace BeVelS.Graphics.Samplers.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Graphics.Samplers.Factories.Descriptions;
    using BeVelS.Graphics.Samplers.InterfacesAbstractFactories;
    using BeVelS.Graphics.Samplers.InterfacesFactories.Descriptions;

    public sealed class SamplersAbstractFactory : ISamplersAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SamplersAbstractFactory()
        {
        }

        public ISamplerDescriptionFactory CreateSamplerDescriptionFactory()
        {
            ISamplerDescriptionFactory factory = null;

            try
            {
                factory = new SamplerDescriptionFactory();
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