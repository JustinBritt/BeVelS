namespace BeVelS.ECS.Systems.Framebuffers.Factories
{
    using System;

    using log4net;

    using DefaultEcs;

    using BeVelS.ECS.Systems.Framebuffers.Classes;
    using BeVelS.ECS.Systems.Framebuffers.Interfaces;
    using BeVelS.ECS.Systems.Framebuffers.InterfacesFactories;

    using BeVelS.Graphics.Framebuffers.InterfacesFactories.Descriptions;

    internal sealed class ResolvedFramebufferSystemFactory : IResolvedFramebufferSystemFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ResolvedFramebufferSystemFactory()
        {
        }

        public IResolvedFramebufferSystem Create(
            IFramebufferDescriptionFactory framebufferDescriptionFactory,
            World world)
        {
            IResolvedFramebufferSystem system = null;

            try
            {
                system = new ResolvedFramebufferSystem(
                    framebufferDescriptionFactory,
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