namespace BeVelS.ECS.Components.Guids.Factories
{
    using System;

    using log4net;

    using BeVelS.ECS.Components.Guids.InterfacesFactories;
    using BeVelS.ECS.Components.Guids.Structs;

    internal sealed class GuidComponentFactory : IGuidComponentFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public GuidComponentFactory()
        {
        }

        public GuidComponent Create()
        {
            GuidComponent component = default;

            try
            {
                component = new GuidComponent();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return component;
        }

        public GuidComponent Create(
            Guid value)
        {
            GuidComponent component = default;

            try
            {
                component = new GuidComponent(
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