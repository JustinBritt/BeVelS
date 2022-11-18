namespace BeVelS.ECS.Systems.RenderTargets.Factories
{
    using System;

    using log4net;

    using DefaultEcs;

    using BeVelS.ECS.Systems.RenderTargets.Classes;
    using BeVelS.ECS.Systems.RenderTargets.Interfaces;
    using BeVelS.ECS.Systems.RenderTargets.InterfacesFactories;

    using BeVelS.Graphics.Textures.InterfacesFactories;

    internal sealed class DepthBufferSystemFactory : IDepthBufferSystemFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DepthBufferSystemFactory()
        {
        }

        public IDepthBufferSystem Create(
            ITextureFactory textureFactory,
            World world)
        {
            IDepthBufferSystem system = null;

            try
            {
                system = new DepthBufferSystem(
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