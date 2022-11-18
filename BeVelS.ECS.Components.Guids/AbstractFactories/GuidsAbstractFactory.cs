namespace BeVelS.ECS.Components.Guids.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.ECS.Components.Guids.Factories;
    using BeVelS.ECS.Components.Guids.InterfacesAbstractFactories;
    using BeVelS.ECS.Components.Guids.InterfacesFactories;

    public sealed class GuidsAbstractFactory : IGuidsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public GuidsAbstractFactory()
        {
        }

        public ICollectionGuidComponentFactory CreateCollectionGuidComponentFactory()
        {
            ICollectionGuidComponentFactory factory = null;

            try
            {
                factory = new CollectionGuidComponentFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IGuidComponentFactory CreateGuidComponentFactory()
        {
            IGuidComponentFactory factory = null;

            try
            {
                factory = new GuidComponentFactory();
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