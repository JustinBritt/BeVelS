namespace BeVelS.Graphics.ResourceSets.Factories.Descriptions
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.Graphics.ResourceSets.InterfacesFactories.Descriptions;

    internal sealed class ResourceSetDescriptionFactory : IResourceSetDescriptionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ResourceSetDescriptionFactory()
        {
        }

        public ResourceSetDescription Create(
            ResourceLayout layout,
            params BindableResource[] boundResources)
        {
            ResourceSetDescription resourceSetDescription = default;

            try
            {
                resourceSetDescription = new ResourceSetDescription(
                    layout,
                    boundResources);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return resourceSetDescription;
        }
    }
}