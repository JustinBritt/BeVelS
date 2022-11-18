namespace BeVelS.ECS.Components.Resolutions.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Components.Resolutions.Factories;
    using BeVelS.ECS.Components.Resolutions.InterfacesAbstractFactories;
    using BeVelS.ECS.Components.Resolutions.InterfacesFactories;

    public sealed class ResolutionsAbstractFactory : IResolutionsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ResolutionsAbstractFactory()
        {
        }

        public IResolutionComponentFactory CreateResolutionComponentFactory()
        {
            IResolutionComponentFactory factory = null;

            try
            {
                factory = new ResolutionComponentFactory();
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