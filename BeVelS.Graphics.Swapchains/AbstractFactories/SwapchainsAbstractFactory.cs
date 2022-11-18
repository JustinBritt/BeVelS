namespace BeVelS.Graphics.Swapchains.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Graphics.Swapchains.Factories.Descriptions;
    using BeVelS.Graphics.Swapchains.InterfacesAbstractFactories;
    using BeVelS.Graphics.Swapchains.InterfacesFactories.Descriptions;

    public sealed class SwapchainsAbstractFactory : ISwapchainsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SwapchainsAbstractFactory()
        {
        }

        public ISwapchainDescriptionFactory CreateSwapchainDescriptionFactory()
        {
            ISwapchainDescriptionFactory factory = null;

            try
            {
                factory = new SwapchainDescriptionFactory();
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