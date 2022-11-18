namespace BeVelS.ECS.Systems.Framebuffers.Factories
{
    using System;

    using log4net;

    using DefaultEcs;

    using BeVelS.ECS.Systems.Framebuffers.Classes;
    using BeVelS.ECS.Systems.Framebuffers.Interfaces;
    using BeVelS.ECS.Systems.Framebuffers.InterfacesFactories;
    using BeVelS.ECS.Systems.InterfacesFactories;
    using BeVelS.ECS.Systems.RenderTargets.InterfacesFactories;

    using BeVelS.Graphics.Framebuffers.InterfacesFactories.Descriptions;
    using BeVelS.Graphics.Textures.InterfacesFactories;
    
    internal sealed class FramebufferingSystemFactory : IFramebufferingSystemFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FramebufferingSystemFactory()
        {
        }

        public IFramebufferingSystem Create(
            ISequentialSystemFactory sequentialSystemFactory,
            IFramebufferSystemFactory framebufferSystemFactory,
            IResolvedFramebufferSystemFactory resolvedFramebufferSystemFactory,
            IColorBufferSystemFactory colorBufferSystemFactory,
            IDepthBufferSystemFactory depthBufferSystemFactory,
            IResolvedColorBufferSystemFactory resolvedColorBufferSystemFactory,
            IFramebufferDescriptionFactory framebufferDescriptionFactory,
            ITextureFactory textureFactory,
            World world)
        {
            IFramebufferingSystem system = null;

            try
            {
                system = new FramebufferingSystem(
                    sequentialSystemFactory,
                    framebufferSystemFactory,
                    resolvedFramebufferSystemFactory,
                    colorBufferSystemFactory,
                    depthBufferSystemFactory,
                    resolvedColorBufferSystemFactory,
                    framebufferDescriptionFactory,
                    textureFactory,
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