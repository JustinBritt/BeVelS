namespace BeVelS.Graphics.DepthStencilStates.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Graphics.DepthStencilStates.Factories.Descriptions;
    using BeVelS.Graphics.DepthStencilStates.InterfacesAbstractFactories;
    using BeVelS.Graphics.DepthStencilStates.InterfacesFactories.Descriptions;

    public sealed class DepthStencilStatesAbstractFactory : IDepthStencilStatesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DepthStencilStatesAbstractFactory()
        {
        }

        public IDepthStencilStateDescriptionFactory CreateDepthStencilStateDescriptionFactory()
        {
            IDepthStencilStateDescriptionFactory factory = null;

            try
            {
                factory = new DepthStencilStateDescriptionFactory();
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