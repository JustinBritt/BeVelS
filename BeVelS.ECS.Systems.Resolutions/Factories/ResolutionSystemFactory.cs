namespace BeVelS.ECS.Systems.Resolutions.Factories
{
    using System;
    using System.Numerics;

    using log4net;

    using DefaultEcs;

    using BeVelS.ECS.Systems.Resolutions.Classes;
    using BeVelS.ECS.Systems.Resolutions.Interfaces;
    using BeVelS.ECS.Systems.Resolutions.InterfacesFactories;

    internal sealed class ResolutionSystemFactory : IResolutionSystemFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ResolutionSystemFactory()
        {
        }

        public IResolutionSystem Create(
            Vector2 resolution,
            World world)
        {
            IResolutionSystem system = null;

            try
            {
                system = new ResolutionSystem(
                    resolution,
                    world);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return system;
        }
    }
}