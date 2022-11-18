namespace BeVelS.Graphics.ResourceSets.AbstractFactories
{
    using System;

    using log4net;

    using BeVelS.Graphics.ResourceSets.Factories;
    using BeVelS.Graphics.ResourceSets.Factories.Descriptions;
    using BeVelS.Graphics.ResourceSets.InterfacesAbstractFactories;
    using BeVelS.Graphics.ResourceSets.InterfacesFactories;
    using BeVelS.Graphics.ResourceSets.InterfacesFactories.Descriptions;

    public sealed class ResourceSetsAbstractFactory : IResourceSetsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ResourceSetsAbstractFactory()
        {
        }

        public IResourceSetDescriptionFactory CreateResourceSetDescriptionFactory()
        {
            IResourceSetDescriptionFactory factory = null;

            try
            {
                factory = new ResourceSetDescriptionFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IResourceSetFactory CreateResourceSetFactory()
        {
            IResourceSetFactory factory = null;

            try
            {
                factory = new ResourceSetFactory();
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