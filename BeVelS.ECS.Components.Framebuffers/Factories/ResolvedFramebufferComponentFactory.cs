namespace BeVelS.ECS.Components.Framebuffers.Factories
{
    using System;

    using log4net;

    using Veldrid;

    using BeVelS.ECS.Components.Framebuffers.InterfacesFactories;
    using BeVelS.ECS.Components.Framebuffers.Structs;

    internal sealed class ResolvedFramebufferComponentFactory : IResolvedFramebufferComponentFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ResolvedFramebufferComponentFactory()
        {
        }

        public ResolvedFramebufferComponent Create(
            Framebuffer value)
        {
            ResolvedFramebufferComponent component = default;

            try
            {
                component = new ResolvedFramebufferComponent(
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