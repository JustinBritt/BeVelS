namespace BeVelS.ECS.Components.Resolutions.Factories
{
    using System;

    using log4net;

    using BepuUtilities;

    using BeVelS.ECS.Components.Resolutions.InterfacesFactories;
    using BeVelS.ECS.Components.Resolutions.Structs;

    internal sealed class ResolutionComponentFactory : IResolutionComponentFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ResolutionComponentFactory()
        {
        }

        public ResolutionComponent Create(
            Int2 value)
        {
            ResolutionComponent component = default;

            try
            {
                component = new ResolutionComponent(
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