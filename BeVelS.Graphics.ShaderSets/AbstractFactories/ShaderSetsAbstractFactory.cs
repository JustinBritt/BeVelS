namespace BeVelS.Graphics.ShaderSets.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Graphics.ShaderSets.Factories.Descriptions;
    using BeVelS.Graphics.ShaderSets.InterfacesAbstractFactories;
    using BeVelS.Graphics.ShaderSets.InterfacesFactories.Descriptions;

    public sealed class ShaderSetsAbstractFactory : IShaderSetsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ShaderSetsAbstractFactory()
        {
        }

        public IShaderSetDescriptionFactory CreateShaderSetDescriptionFactory()
        {
            IShaderSetDescriptionFactory factory = null;

            try
            {
                factory = new ShaderSetDescriptionFactory();
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