namespace BeVelS.ECS.Components.Guids.Factories
{
    using System;

    using log4net;

    using BeVelS.ECS.Components.Guids.InterfacesFactories;
    using BeVelS.ECS.Components.Guids.Structs;

    internal sealed class CollectionGuidComponentFactory : ICollectionGuidComponentFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CollectionGuidComponentFactory()
        {
        }

        public CollectionGuidComponent Create(
            Guid value)
        {
            CollectionGuidComponent component = default;

            try
            {
                component = new CollectionGuidComponent(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return component;
        }
    }
}