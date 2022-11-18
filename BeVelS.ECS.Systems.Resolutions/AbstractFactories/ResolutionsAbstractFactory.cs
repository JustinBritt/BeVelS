namespace BeVelS.ECS.Systems.Resolutions.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Systems.Resolutions.Factories;
    using BeVelS.ECS.Systems.Resolutions.InterfacesAbstractFactories;
    using BeVelS.ECS.Systems.Resolutions.InterfacesFactories;

    public sealed class ResolutionsAbstractFactory : IResolutionsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ResolutionsAbstractFactory()
        {
        }

        public IResolutionSystemFactory CreateResolutionSystemFactory()
        {
            IResolutionSystemFactory factory = null;

            try
            {
                factory = new ResolutionSystemFactory();
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