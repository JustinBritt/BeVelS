namespace BeVelS.Graphics.RasterizerStates.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Graphics.RasterizerStates.Factories.Descriptions;
    using BeVelS.Graphics.RasterizerStates.InterfacesAbstractFactories;
    using BeVelS.Graphics.RasterizerStates.InterfacesFactories.Descriptions;

    public sealed class RasterizerStatesAbstractFactory : IRasterizerStatesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RasterizerStatesAbstractFactory()
        {
        }

        public IRasterizerStateDescriptionFactory CreateRasterizerStateDescriptionFactory()
        {
            IRasterizerStateDescriptionFactory factory = null;

            try
            {
                factory = new RasterizerStateDescriptionFactory();
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